using Analizer.Functions;
using System;
using System.Windows.Forms;

namespace Analizer
{
    public partial class Load : Form
    {
        public static int ConfigIndex = 0;
        public Load()
        {
            InitializeComponent();
        }

        async void btnLoad_Click(object sender, EventArgs e)
        {
            NeuronHelper neuronHelper = new NeuronHelper();
            await neuronHelper.LoadFromCsv();
        }
    }
}