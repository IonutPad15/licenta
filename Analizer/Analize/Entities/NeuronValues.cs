using System.Runtime.Serialization;
using System.Text;

namespace Analizer
{
    [DataContract]
    public class NeuronValues
    {
        [DataMember]
        public double Gin { get; set; }

        [DataMember]
        public double Actv { get; set; }

        [DataMember]
        public EntryOut Out { get; set; }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendLine($"\t\t\t\t\tGin:{Gin}");
            sb.AppendLine($"\t\t\t\t\tActv:{Actv}");
            sb.AppendLine($"\t\t\t\t\tOut:{Out.Value}");

            return sb.ToString();
        }

    }
}
