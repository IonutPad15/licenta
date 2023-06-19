using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Analizer
{
    [DataContract]
    public class Neuron
    {
        [JsonConstructor]
        public Neuron(string name, List<Entry> entries, NeuronValues neuronValues, int btnXId = 0, int btnYId = 0)
        {
            Name = name;
            Entries = entries;
            NeuronValues = neuronValues;
        }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Entry> Entries { get; set; }
        [DataMember]
        public NeuronValues NeuronValues { get; set; }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("\t\t\tNeuron:");
            sb.Append($"\t\t\t\tName:{Name}\n");
            sb.Append($"\t\t\t\tNeuronValues:\n");
            sb.Append(NeuronValues.ToString());
            sb.Append($"\t\t\t\tEntries:\n");
            foreach (Entry entry in Entries)
            {
                sb.Append(entry.ToString());
            }


            return sb.ToString();
        }
    }
}
