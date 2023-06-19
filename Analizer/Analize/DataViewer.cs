using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Analizer
{
    public partial class DataViewer : Form
    {
        public DataViewer(List<NormalizedProperty> normalizedProperties)
        {
            InitializeComponent();
            this.dataGridView.DataSource = normalizedProperties.ToList();

        }
        public DataViewer(List<CsvProperty> csvProperties)
        {
            InitializeComponent();
            this.dataGridView.DataSource = csvProperties.ToList();
        }
    }
}
