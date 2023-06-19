using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Analizer
{
    public class FileHandler
    {
        public static async Task SaveFile(string path, string data)
        {
            using (var isoFileStream =
                    new FileStream(
                        string.Format(path),
                        System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))
            {
                using (var isoFileWriter = new System.IO.StreamWriter(isoFileStream))
                {
                    await isoFileWriter.WriteAsync(data);
                }
            }
        }

        public static async Task<string> LoadFile(string path)
        {
            string data;


            using (var isoFileStream =
                    new FileStream
                        (string.Format(path),
                        System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
            {
                using (var isoFileReader = new System.IO.StreamReader(isoFileStream))
                {
                    data = await isoFileReader.ReadToEndAsync();
                }
            }

            return data;
        }
        public static T LoadXmlFile<T>(string path)
        {
            var fileStream = new FileStream(path, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
            var serializer = new DataContractSerializer(typeof(T));
            T serializedObject = (T)serializer.ReadObject(reader, true);
            reader.Close();
            fileStream.Close();
            return serializedObject;
        }
        public static void SaveXmlFile<T>(T serializedObject, string path)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t"
            };
            var writer = XmlWriter.Create(path, settings);
            serializer.WriteObject(writer, serializedObject);
            writer.Close();
        }
    }
}
