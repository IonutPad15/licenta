using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Analizer
{
    [DataContract]
    public class Entry
    {
        [JsonConstructor]
        public Entry(double x, double w=0)
        {
            //X = x;
            X = new EntryOut(x);
            W = w;
        }
        [DataMember]
        public EntryOut X { get; set; }
        //public double X { get; set; }

        [DataMember]
        public double W { get; set; }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("\t\t\t\tEntry:");
            sb.AppendLine($"\t\t\t\t\tX:{X.Value}");
            //sb.AppendLine($"\t\t\t\t\tX:{X}");
            sb.AppendLine($"\t\t\t\t\tW:{W}");

            return sb.ToString();

        }
    }
}
