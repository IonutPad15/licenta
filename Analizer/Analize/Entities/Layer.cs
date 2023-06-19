using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Analizer
{
    [DataContract]
    public class Layer
    {
        [JsonConstructor]
        public Layer(LayerType layerType, List<Neuron> neurons)
        {
            LayerType = layerType;
            Neurons = neurons;
        }
        [DataMember]
        public LayerType LayerType { get; set; }
        [DataMember]
        public List<Neuron> Neurons { get; set; } = new List<Neuron>();
        [DataMember]
        public LayerFunctions LayerFunctions { get; set; } = new LayerFunctions();
        [DataMember]
        public double A { get; set; } = 1;
        [DataMember]
        public double G { get; set; } = 1;
        [DataMember]
        public double Teta { get; set; } = 0;
       
        override
         public string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("\t\tLayer:\n");
            sb.Append($"\t\t\tA:{A}\n");
            sb.Append($"\t\t\tG:{G}\n");
            sb.Append($"\t\t\tTeta:{Teta}\n");
            sb.Append($"\t\t\tLayerType:{LayerType}\n");
            sb.Append(LayerFunctions.ToString());
            sb.AppendLine("Neurons:");
            foreach (Neuron neuron in Neurons)
            {
                sb.Append(neuron.ToString());
            }

            return sb.ToString();
        }
    }
    public enum LayerType{
        InputLayer,
        OutputLayer,
        HiddenLayer
    }
}
