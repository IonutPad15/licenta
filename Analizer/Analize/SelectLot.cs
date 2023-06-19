using Analizer.Entities;
using System;
using System.Windows.Forms;

namespace Analizer
{
    public partial class SelectLot : Form
    {
        public SelectLot()
        {
            InitializeComponent();
        }

        private void btnAntrenamentRaw_Click(object sender, EventArgs e)
        {
            DataViewer dv = new DataViewer(Sets.TrainingRaw);
            dv.ShowDialog();
        }

        private void btnAntrenamentNorm_Click(object sender, EventArgs e)
        {
            DataViewer dv = new DataViewer(Sets.TrainingNorm);
            dv.ShowDialog();
        }

        private void btnTestareRaw_Click(object sender, EventArgs e)
        {
            DataViewer dv = new DataViewer(Sets.TestingRaw);
            dv.ShowDialog();
        }

        private void btnTestareNorm_Click(object sender, EventArgs e)
        {
            DataViewer dv = new DataViewer(Sets.TestingNorm);
            dv.ShowDialog();
        }
    }
}
