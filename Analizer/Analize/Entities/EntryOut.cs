using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Analizer
{
    [DataContract]
    public class EntryOut
    {
        [JsonConstructor]
        public EntryOut(double value)
        {
            Value = value;
        }
        [DataMember]
        public double Value { get; set; }
    }
}
