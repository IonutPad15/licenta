namespace Analizer
{
    partial class Generated
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnViewData = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBetterTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnLoadAi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.errorPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelButtons.SuspendLayout();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(12, 22);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(140, 42);
            this.btnViewData.TabIndex = 0;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.BtnViewData_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnBetterTest);
            this.panelButtons.Controls.Add(this.lblTest);
            this.panelButtons.Controls.Add(this.btnExec);
            this.panelButtons.Controls.Add(this.btnLoadAi);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.btnTest);
            this.panelButtons.Controls.Add(this.btnConfig);
            this.panelButtons.Controls.Add(this.btnStop);
            this.panelButtons.Controls.Add(this.btnStart);
            this.panelButtons.Controls.Add(this.btnViewData);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 555);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1326, 124);
            this.panelButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(450, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save AI";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBetterTest
            // 
            this.btnBetterTest.Location = new System.Drawing.Point(12, 79);
            this.btnBetterTest.Name = "btnBetterTest";
            this.btnBetterTest.Size = new System.Drawing.Size(140, 42);
            this.btnBetterTest.TabIndex = 10;
            this.btnBetterTest.Text = "Better Test";
            this.btnBetterTest.UseVisualStyleBackColor = true;
            this.btnBetterTest.Click += new System.EventHandler(this.btnBetterTest_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(1091, 72);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 22);
            this.lblTest.TabIndex = 9;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(888, 23);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(140, 42);
            this.btnExec.TabIndex = 8;
            this.btnExec.Text = "Go to exec.";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // btnLoadAi
            // 
            this.btnLoadAi.Location = new System.Drawing.Point(742, 22);
            this.btnLoadAi.Name = "btnLoadAi";
            this.btnLoadAi.Size = new System.Drawing.Size(140, 42);
            this.btnLoadAi.TabIndex = 7;
            this.btnLoadAi.Text = "Load AI";
            this.btnLoadAi.UseVisualStyleBackColor = true;
            this.btnLoadAi.Click += new System.EventHandler(this.BtnLoadAI_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1087, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Learning rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1087, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chosen Error:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(596, 22);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(140, 42);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(158, 22);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(140, 42);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Configure";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(450, 23);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 42);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(304, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.errorPannel);
            this.panelGraph.Controls.Add(this.chart1);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(0, 0);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(1326, 555);
            this.panelGraph.TabIndex = 2;
            // 
            // errorPannel
            // 
            this.errorPannel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.errorPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.errorPannel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.errorPannel.Location = new System.Drawing.Point(1126, 0);
            this.errorPannel.Name = "errorPannel";
            this.errorPannel.Size = new System.Drawing.Size(200, 555);
            this.errorPannel.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Errors";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1120, 555);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Generated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 679);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Generated";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generated";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.FlowLayoutPanel errorPannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnLoadAi;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnBetterTest;
        private System.Windows.Forms.Button btnSave;
    }
}