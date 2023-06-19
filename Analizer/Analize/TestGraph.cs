using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Analizer
{
    public partial class TestGraph : Form
    {
        Dictionary<int, List<double>> _scorePerDriver;
        int _missingDriver;
        Dictionary<int, double> _means;
        Dictionary<int, double> _sds;
        public TestGraph(Dictionary<int, List<double>> scorePerDriver, int missingDriver)
        {
            _missingDriver = missingDriver;
            _scorePerDriver = scorePerDriver;
            InitializeComponent();
            this.Text = $"Driver {(char)(_missingDriver + 65)}";
            AddToChart();
            //this.chart1.SaveImage($"C:\\Ionut\\final\\1\\chart{(char)(_missingDriver + 65)}.1.png", ChartImageFormat.Png);
            //this.chart2.SaveImage($"C:\\Ionut\\final\\1\\chart{(char)(_missingDriver + 65)}.2.png", ChartImageFormat.Png);
        }
        public TestGraph(Dictionary<int, List<double>> scorePerDriver, int missingDriver, Dictionary<int, double> means, Dictionary<int, double> sds)
        {
            _missingDriver = missingDriver;
            _scorePerDriver = scorePerDriver;
            _means = means;
            _sds = sds;
            InitializeComponent();
            this.Text = $"Driver {(char)(_missingDriver + 65)}";
            AddToChartExtended();
        }

        void AddToChartExtended()
        {
            double mean = _means[0];
            double sd = _sds[0];
            for (int i = 0; i < _scorePerDriver[0].Count; i++)
            {
                chart1.Series["mean"].Points.AddXY(i, mean);
                chart1.Series["SD"].Points.AddXY(i, sd);
            }
            chart1.MaximumSize = new Size(new Point(_scorePerDriver[0].Count, chart1.MaximumSize.Height));
            for (int j = 0; j < _scorePerDriver[0].Count; j++)
            {
                chart1.Series["Driver"].Points.AddXY(j, _scorePerDriver[0][j]);
            }
            mean = _means[1];
            sd = _sds[1];
            for (int i = 0; i < _scorePerDriver[1].Count; i++)
            {
                chart2.Series["mean"].Points.AddXY(i, mean);
                chart2.Series["SD"].Points.AddXY(i, sd);
            }
            for (int j = 0; j < _scorePerDriver[1].Count; j++)
            {
                chart2.Series["Driver"].Points.AddXY(j, _scorePerDriver[1][j]);
            }
        }

        void AddToChart()
        {
            NeuronFunctions neuronFunctions = new NeuronFunctions();
            double mean = _scorePerDriver[0].Average();
            double sd = mean - neuronFunctions.StandardDeviation(_scorePerDriver[0]);
            meanGraph1.Text = $"Mean: {mean} %";
            tresHoldGraph1.Text = $"Threshold: {sd} %";
            for (int i = 0; i < _scorePerDriver[0].Count; i++)
            {
                chart1.Series["mean"].Points.AddXY(i, mean);
                chart1.Series["SD"].Points.AddXY(i, sd);
            }
            chart1.ChartAreas[0].AxisY.Title = "Score (%)";
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Times", 10F, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.Title = "Index of data tested";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Times", 10F, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = _scorePerDriver[0].Count;
            //chart1.ChartAreas[0].AxisY.Interval = 20;
            Console.WriteLine(chart1.ChartAreas[0].AxisY.Interval);
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0}";
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0}";
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Times", 10F, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times", 10F, FontStyle.Bold);
            chart1.Series["mean"].Font = new Font("Times", 10F, FontStyle.Bold);
            chart1.Series["SD"].Font = new Font("Times", 10F, FontStyle.Bold);
            chart1.Series["Driver"].Font = new Font("Times", 10F, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;

            // Show scale break if more than 25% of the chart is empty space.  
            chart1.ChartAreas[0].AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 20;

            // Set the line width of the scale break.  
            chart1.ChartAreas[0].AxisY.ScaleBreakStyle.LineWidth = 2;

            // Set the color of the scale break.  
            chart1.ChartAreas[0].AxisY.ScaleBreakStyle.LineColor = Color.Purple;

            // If all data points are significantly far from zero, the chart will calculate the scale minimum value.  
            chart1.ChartAreas[0].AxisY.ScaleBreakStyle.StartFromZero = StartFromZero.Auto;

            // Set the spacing gap between the lines of the scale break (as a percentage of the Y-axis).  
            chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Spacing = 2;
            for (int j = 0; j < _scorePerDriver[0].Count; j++)
            {
                chart1.Series["Driver"].Points.AddXY(j, _scorePerDriver[0][j]);
                if (_scorePerDriver[0][j] < sd)
                {
                    chart1.Series["Driver"].Points.ElementAt(j).Color = Color.Red;
                }
                else
                {
                    chart1.Series["Driver"].Points.ElementAt(j).Color = Color.Green;
                }
            }
            mean = 100 - _scorePerDriver[1].Average();
            sd = (mean + neuronFunctions.StandardDeviation(_scorePerDriver[1]));
            meanGraph2.Text = $"Mean: {mean} %";
            tresHoldGraph2.Text = $"Threshold: {sd} %";
            for (int i = 0; i < _scorePerDriver[1].Count; i++)
            {
                chart2.Series["mean"].Points.AddXY(i, mean);
                chart2.Series["SD"].Points.AddXY(i, sd);
            }
            chart2.ChartAreas[0].AxisY.Title = " Score (%)";
            chart2.ChartAreas[0].AxisY.TitleFont = new Font("Times", 10F, FontStyle.Bold);
            chart2.ChartAreas[0].AxisX.Title = "Index of data tested";
            chart2.ChartAreas[0].AxisX.TitleFont = new Font("Times", 10F, FontStyle.Bold);
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = _scorePerDriver[1].Count;
            //chart2.ChartAreas[0].AxisY.Interval = 100;
            chart2.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0}";
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0}";
            chart2.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Times", 10F, FontStyle.Bold);
            chart2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times", 10F, FontStyle.Bold);
            chart2.Series["mean"].Font = new Font("Times", 10F, FontStyle.Bold);
            chart2.Series["SD"].Font = new Font("Times", 10F, FontStyle.Bold);
            chart2.Series["Driver"].Font = new Font("Times", 10F, FontStyle.Bold);
            chart2.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;

            // Show scale break if more than 25% of the chart is empty space.  
            chart2.ChartAreas[0].AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 20;

            // Set the line width of the scale break.  
            chart2.ChartAreas[0].AxisY.ScaleBreakStyle.LineWidth = 2;

            // Set the color of the scale break.  
            chart2.ChartAreas[0].AxisY.ScaleBreakStyle.LineColor = Color.Purple;

            // If all data points are significantly far from zero, the chart will calculate the scale minimum value.  
            chart2.ChartAreas[0].AxisY.ScaleBreakStyle.StartFromZero = StartFromZero.Auto;

            // Set the spacing gap between the lines of the scale break (as a percentage of the Y-axis).  
            chart2.ChartAreas[0].AxisY.ScaleBreakStyle.Spacing = 2;

            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            for (int j = 0; j < _scorePerDriver[1].Count; j++)
            {
                double value = 100 - _scorePerDriver[1][j];
                chart2.Series["Driver"].Points.AddXY(j, value);
                if (value > sd)
                {
                    chart2.Series["Driver"].Points.ElementAt(j).Color = Color.Red;
                }
                else
                {
                    chart2.Series["Driver"].Points.ElementAt(j).Color = Color.Green;
                }
            }
            //chart2.ChartAreas[0].AxisY.CustomLabels.Add(100, 100, "100");
            //chart2.ChartAreas[0].AxisY.CustomLabels.Add(mean, mean, String.Format("{0:0.0}", mean));
            //chart2.ChartAreas[0].AxisY.CustomLabels.Add(sd, sd, String.Format("{0:0.0}", sd));
        }
    }
}
