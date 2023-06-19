using System;
using System.Linq;
using System.Windows.Forms;

namespace Analizer
{
    public partial class Execution : Form
    {
        MainPannel _network;
        int _ignoreIndex;
        public Execution()
        {
            InitializeComponent();
        }
        public Execution(int ignoreIndex, MainPannel mainPannel)
        {
            InitializeComponent();
            _network = mainPannel;
            _ignoreIndex = ignoreIndex;
        }
  
        void btnFurtExec_Click(object sender, EventArgs e)
        {
            if(_network.Layers.First().Neurons.Count != 14)
            {
                MessageBox.Show("The config is not right!");
                return;
            }
            double ltftbN = Normalize.Start((double)ltftb.Value, -1.6, 10.2, 0, 1);
            double estN = Normalize.Start((double)est.Value, 0, 255, 0, 1);
            double ect2N = Normalize.Start((double)ect2.Value, -40, 105, 0, 1);
            double tofN = Normalize.Start((double)tof.Value, 0, 28.1, 0, 1);
            double iapN = Normalize.Start((double)iap.Value, 0, 178, 0, 1);
            double aoacN = Normalize.Start((double)aoac.Value, 0, 1, 0, 1);
            double timeN = Normalize.Start((double)time.Value, 1, 2948, 0, 1);
            double apvN = Normalize.Start((double)apv.Value, 0, 99.2, 0, 1);
            double etN = Normalize.Start((double)et.Value, 0, 83.6, 0, 1);
            double mietN = Normalize.Start((double)miet.Value, 0, 91.4, 0, 1);
            double clvN = Normalize.Start((double)clv.Value, 0, 98.4, 0, 1);
            double tpsN = Normalize.Start((double)tps.Value, 0, 100, 0, 1);
            double etacN = Normalize.Start((double)etac.Value, 0, 83.6, 0, 1);
            double ect1N = Normalize.Start((double)ect1.Value, -40, 96, 0, 1);
            _network.Layers[0].Neurons[0].Entries[0].X.Value = ltftbN;
            _network.Layers[0].Neurons[1].Entries[0].X.Value = estN;
            _network.Layers[0].Neurons[2].Entries[0].X.Value = ect2N;
            _network.Layers[0].Neurons[3].Entries[0].X.Value = tofN;
            _network.Layers[0].Neurons[4].Entries[0].X.Value = iapN;
            _network.Layers[0].Neurons[5].Entries[0].X.Value = aoacN;
            _network.Layers[0].Neurons[6].Entries[0].X.Value = timeN;
            _network.Layers[0].Neurons[7].Entries[0].X.Value = apvN;
            _network.Layers[0].Neurons[8].Entries[0].X.Value = etN;
            _network.Layers[0].Neurons[9].Entries[0].X.Value = mietN;
            _network.Layers[0].Neurons[10].Entries[0].X.Value = clvN;
            _network.Layers[0].Neurons[11].Entries[0].X.Value = tpsN;
            _network.Layers[0].Neurons[12].Entries[0].X.Value = etacN;
            _network.Layers[0].Neurons[13].Entries[0].X.Value = ect1N;
            NeuronFunctions neuronFunctions = new NeuronFunctions();
            _network = neuronFunctions.DoMath(0, _network);
            _network.Layers.Last().Neurons = neuronFunctions.SoftMax(_network.Layers.Last().Neurons);
            string result = $" Driver {(char)(_ignoreIndex+65)}: {_network.Layers.Last().Neurons.First().NeuronValues.Out.Value} %\n" +
                $"Stolen: {_network.Layers.Last().Neurons.Last().NeuronValues.Out.Value} %";
            MessageBox.Show(result);
        }
    }
}
