namespace Analizer
{
    partial class TestGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.meanGraph1 = new System.Windows.Forms.Label();
            this.tresHoldGraph1 = new System.Windows.Forms.Label();
            this.meanGraph2 = new System.Windows.Forms.Label();
            this.tresHoldGraph2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.LegendText = "Driver";
            series1.Name = "Driver";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Name = "mean";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Name = "SD";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(397, 365);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(415, 12);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.LegendText = "Driver";
            series4.Name = "Driver";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series5.Name = "mean";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Name = "SD";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(397, 365);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // meanGraph1
            // 
            this.meanGraph1.AutoSize = true;
            this.meanGraph1.Location = new System.Drawing.Point(28, 384);
            this.meanGraph1.Name = "meanGraph1";
            this.meanGraph1.Size = new System.Drawing.Size(44, 16);
            this.meanGraph1.TabIndex = 2;
            this.meanGraph1.Text = "label1";
            // 
            // tresHoldGraph1
            // 
            this.tresHoldGraph1.AutoSize = true;
            this.tresHoldGraph1.Location = new System.Drawing.Point(28, 404);
            this.tresHoldGraph1.Name = "tresHoldGraph1";
            this.tresHoldGraph1.Size = new System.Drawing.Size(44, 16);
            this.tresHoldGraph1.TabIndex = 3;
            this.tresHoldGraph1.Text = "label1";
            // 
            // meanGraph2
            // 
            this.meanGraph2.AutoSize = true;
            this.meanGraph2.Location = new System.Drawing.Point(415, 384);
            this.meanGraph2.Name = "meanGraph2";
            this.meanGraph2.Size = new System.Drawing.Size(44, 16);
            this.meanGraph2.TabIndex = 4;
            this.meanGraph2.Text = "label1";
            // 
            // tresHoldGraph2
            // 
            this.tresHoldGraph2.AutoSize = true;
            this.tresHoldGraph2.Location = new System.Drawing.Point(415, 404);
            this.tresHoldGraph2.Name = "tresHoldGraph2";
            this.tresHoldGraph2.Size = new System.Drawing.Size(44, 16);
            this.tresHoldGraph2.TabIndex = 5;
            this.tresHoldGraph2.Text = "label1";
            // 
            // TestGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 494);
            this.Controls.Add(this.tresHoldGraph2);
            this.Controls.Add(this.meanGraph2);
            this.Controls.Add(this.tresHoldGraph1);
            this.Controls.Add(this.meanGraph1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TestGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestGraph";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label meanGraph1;
        private System.Windows.Forms.Label tresHoldGraph1;
        private System.Windows.Forms.Label meanGraph2;
        private System.Windows.Forms.Label tresHoldGraph2;
    }
}