using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Analizer
{
    [DataContract]
    public class LayerFunctions
    {
        [JsonConstructor]
        public LayerFunctions(GICode gICode = GICode.Suma, ActivCode activCode = ActivCode.Sigmoidala, bool isReal = true)
        {
            GICode = gICode;
            ActivCode = activCode;
            IsReal = isReal;
        }
        [DataMember]
        public GICode GICode { get; set; }
        [DataMember]
        public ActivCode ActivCode { get; set; }
        [DataMember]
        public bool IsReal { get; set; }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("\t\t\tLayerFunctions:\n");
            sb.Append($"\t\t\t\tGICode:{GICode}\n");
            sb.Append($"\t\t\t\tActivCode:{ActivCode}\n");
            sb.Append($"\t\t\t\tIsReal:{IsReal}\n");

            return sb.ToString();
        }
    }
}