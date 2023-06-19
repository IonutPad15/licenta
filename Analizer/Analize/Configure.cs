using Analizer.Functions;
using System;
using System.Windows.Forms;

namespace Analizer
{
    public partial class Configure : Form
    {
        int _nrInputProperties;
        int _nrOutputProperties;

        static int _nrConfig = 0;
        static bool isFirst = true;
        public static MainPannel Network;
        public Configure()
        {
            InitializeComponent();
            if (isFirst == true)
            {
                btnOk.Enabled = false;
                btnCreateNew.Enabled = true;
            }
            else
            {
                btnOk.Enabled = true;
                btnCreateNew.Enabled = false;
            }
            _nrInputProperties = NeuronProperties.InputCount<NormalizedProperty>();
            _nrOutputProperties = NeuronProperties.OutputCount<NormalizedProperty>();
            upDownHL1.Minimum = 1;
            upDownHL2.Minimum = 1;
            upDownHL3.Minimum = 1;
            isFirst = false;
           
            upDownHL1.Maximum = _nrInputProperties * 10;
            upDownHL2.Maximum = _nrInputProperties * 10;
            upDownHL3.Maximum = _nrInputProperties * 10;
            InitHL();
        }

        void OK_Click(object sender, EventArgs e)
        {
            int nril = (int)upDownIL.Value;
            if (nril != 14 && nril != 6 && nril != 38 && nril != 53)
            {
                MessageBox.Show("Possbile values: 6/14/38/53");
                return;
            }
            if (nril == 0)
            {
                nril = _nrInputProperties;
            }
            //int nrol = nrOutputProperties;
            int nrol = 2;
            int nrhl = (int)upDownHL.Value;
            int nrhl1 = (int)upDownHL1.Value;
            int nrhl2 = (int)upDownHL2.Value;
            int nrhl3 = (int)upDownHL3.Value;

            double learningRate = (double)upDownLearningRate.Value;
            double error = (double)upDownError.Value;

            NeuronHelper neuronHelper = new NeuronHelper();
            Network = neuronHelper.GenerateConfig(nril, nrol, nrhl, learningRate, error, nrhl1, nrhl2, nrhl3);

            this.DialogResult = DialogResult.OK;
        }
        void InitHL()
        {
            //upDownHL2.Value = _nrInputProperties * 2;
            //upDownHL3.Value = _nrInputProperties * 2;
            //upDownHL1.Value = _nrInputProperties * 2;
            upDownHL2.Value = 14 * 3;
            upDownHL3.Value = 14 * 6;
            upDownHL1.Value = 14 * 6;
            upDownHL2.Visible = false;
            upDownHL3.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;

        }

        void UpDownHL_ValueChanged(object sender, EventArgs e)
        {
            InitHL();
            if (upDownHL.Value == 2)
            {
                upDownHL2.Visible = true;
                lbl2.Visible = true;
            }
            else if (upDownHL.Value == 3)
            {
                upDownHL2.Visible = true;
                lbl2.Visible = true;
                upDownHL3.Visible = true;
                lbl3.Visible = true;
            }
        }

        void Configure_Load(object sender, EventArgs e)
        {

        }

        void CreateNew_Click(object sender, EventArgs e)
        {
            int nril = (int)upDownIL.Value;
            if (nril == 0)
            {
                nril = _nrInputProperties;
            }
            //int nrol = nrOutputProperties;
            int nrol = 9;
            int nrhl = (int)upDownHL.Value;
            int nrhl1 = (int)upDownHL1.Value;
            int nrhl2 = (int)upDownHL2.Value;
            int nrhl3 = (int)upDownHL3.Value;

            double learningRate = (double)upDownLearningRate.Value;
            double error = (double)upDownError.Value;

            if (_nrConfig > 9)
            {
                MessageBox.Show("Maximum capacity reached!");
                return;
            }

            NeuronHelper neuronHelper = new NeuronHelper();
            Network = neuronHelper.GenerateConfig(nril, nrol, nrhl, learningRate, error, nrhl1, nrhl2, nrhl3);

            Generated generated = new Generated(_nrConfig);
            generated.Show();
            ++_nrConfig;
        }
    }
}
