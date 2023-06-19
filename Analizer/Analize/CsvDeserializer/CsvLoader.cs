using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Analizer
{
    public class CsvLoader
    {
        public static IEnumerable<T> Load<T>(Stream stream)
        {
            List<T> result = new List<T>();

            Type type = typeof(T);
            var readerConfiguration = type.GetCustomAttributes().FirstOrDefault(a => a.GetType() == typeof(CsvAttribute)) as CsvAttribute;
            var csvTable = new DataTable();

            TextReader reader = new StreamReader(stream);

            using (var csvReader = new CsvReader(reader, true, readerConfiguration?.Delimiter ?? CsvAttribute.DefaultDelimiter))
            {
                csvTable.Load(csvReader);
            }

            var constructor = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).FirstOrDefault();
            Type columnNameAttribute = typeof(ColumnNameAttribute);
            var properties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Where(m => m.CustomAttributes.Any(a => a.AttributeType == columnNameAttribute));

            if (properties.Any() == false)
                throw new ApplicationException($"CsvDeserializer.Load - Missing ColumnNameAttribute from {typeof(T).Name}!");

            //cache order and type
            Dictionary<int, PropertyInfo> propertiesOrder = new Dictionary<int, PropertyInfo>();
            for (int columnIndex = 0; columnIndex < csvTable.Rows[0].ItemArray.Length; ++columnIndex)
            {
                var propName = csvTable.Columns[columnIndex].ToString();
                var propType = properties.FirstOrDefault(p => p.CustomAttributes.Any(a => a.AttributeType == columnNameAttribute && a.ConstructorArguments.First().Value?.ToString() == propName));
                propertiesOrder.Add(columnIndex, propType);
            }
            for (int rowIndex = 0; rowIndex < csvTable.Rows.Count; ++rowIndex)//skip the first line (header)
            {
                var values = new Dictionary<string, (PropertyInfo PropertyInfo, object Value)>();
                for (int columnIndex = 0; columnIndex < csvTable.Rows[rowIndex].ItemArray.Length; ++columnIndex)
                {
                    var property = propertiesOrder[columnIndex];
                    var propValue = csvTable.Rows[rowIndex].ItemArray[columnIndex].ToString();
                    if (property != null)
                    {
                        object value = null;
                        try
                        {
                            //this is done to convert in the type the property is defined in the class that was sent here
                            value = propValue;
                            if (property.PropertyType == typeof(bool))
                            {
                                value = ConvertToBool(propValue);
                            }
                            else if (property.PropertyType != typeof(string))
                            {
                                if (string.IsNullOrEmpty(propValue))
                                    value = default;
                                else
                                {
                                    Type conversionType = property.PropertyType;
                                    if (property.PropertyType.GetTypeInfo().IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                        conversionType = property.PropertyType.GetGenericArguments().First();
                                    value = Convert.ChangeType(propValue, conversionType);
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }

                        values.Add(property.Name.ToLower(), (property, value));
                    }
                }

                T row;
                var arguments = new object[0];
                if (constructor != null)
                {
                    var parameters = constructor.GetParameters();
                    arguments = new object[parameters.Length];
                    for (int p = 0; p < parameters.Length; ++p)
                    {
                        var parameterName = parameters[p].Name?.ToLower();
                        if (string.IsNullOrEmpty(parameterName) == false && values.ContainsKey(parameterName))
                        {
                            arguments[p] = values[parameterName].Value;
                        }
                    }
                }
                row = (T)Activator.CreateInstance(type, bindingAttr: BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, binder: null, args: arguments, null);

                foreach (var property in values.Where(v => v.Value.PropertyInfo.CanWrite))
                {
                    property.Value.PropertyInfo.SetValue(row, property.Value.Value);
                }

                if (row != null)
                {
                    result.Add(row);
                }
            }
            return result;
        }
        private static bool ConvertToBool(string source)
        {
            if (source == null)
                return false;
            var acceptedValue = new string[] { "true", "yes", "y", "1" };
            return acceptedValue.Contains(source.ToLower());
        }
    }
}
