using System;

using System.Linq;
using System.Reflection;

namespace Analizer.Functions
{
    internal class NeuronProperties
    {
        public static int InputCount<T>()
        {
            Type type = typeof(T);
            var readerConfiguration = type.GetCustomAttributes().FirstOrDefault(a => a.GetType() == typeof(NeuronValuesAttribute)) as NeuronValuesAttribute;
            if(readerConfiguration == null)
            {
                throw new ArgumentException("The class must have the NeuronValuesAttribute!");
            }
            Type inputValueAttribute = typeof(InputValueAttribute);
            var properties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Where(m => m.CustomAttributes.Any(a => a.AttributeType == inputValueAttribute));

            if (properties.Any() == false)
            {
                return 0;
            }
            else return properties.Count();
        }
        public static int OutputCount<T>()
        {
            Type type = typeof(T);
            var readerConfiguration = type.GetCustomAttributes().FirstOrDefault(a => a.GetType() == typeof(NeuronValuesAttribute)) as NeuronValuesAttribute;
            if (readerConfiguration == null)
            {
                throw new ArgumentException("The class must have the NeuronValuesAttribute!");
            }
            Type outputValueAttribute = typeof(OutputValueAttribute);
            var properties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Where(m => m.CustomAttributes.Any(a => a.AttributeType == outputValueAttribute));

            if (properties.Any() == false)
            {
                return 0;
            }
            else return properties.Count();
        }
    }
}
