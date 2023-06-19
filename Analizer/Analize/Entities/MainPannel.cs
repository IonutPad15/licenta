using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Analizer
{
    [DataContract]
    [XmlRoot("MainPannel")]
    public class MainPannel
    {
        [DataMember]
        public List<Layer> Layers { get; set; } = new List<Layer>();
        [DataMember]
        public double Error { get; set; }
        [DataMember]
        public double LearningRate { get; set; }
        
        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append($"\tError:{Error}\n");
            sb.Append($"\tLearningRate:{LearningRate}\n");
            sb.Append("MainPannel:\n");
            sb.Append("\tLayers:");
            foreach(Layer layer in Layers)
            {
                sb.Append(layer.ToString());
            }
            return sb.ToString();
        }
    }
}
