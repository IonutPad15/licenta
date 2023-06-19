namespace Analizer
{
    partial class Configure
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
            this.btnOk = new System.Windows.Forms.Button();
            this.upDownHL3 = new System.Windows.Forms.NumericUpDown();
            this.upDownHL2 = new System.Windows.Forms.NumericUpDown();
            this.upDownHL1 = new System.Windows.Forms.NumericUpDown();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upDownHL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upDownError = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.upDownLearningRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.upDownIL = new System.Windows.Forms.NumericUpDown();
            this.btnCreateNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownIL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(289, 308);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.OK_Click);
            // 
            // upDownHL3
            // 
            this.upDownHL3.Location = new System.Drawing.Point(289, 266);
            this.upDownHL3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownHL3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownHL3.Name = "upDownHL3";
            this.upDownHL3.Size = new System.Drawing.Size(92, 28);
            this.upDownHL3.TabIndex = 20;
            this.upDownHL3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upDownHL2
            // 
            this.upDownHL2.Location = new System.Drawing.Point(289, 233);
            this.upDownHL2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownHL2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownHL2.Name = "upDownHL2";
            this.upDownHL2.Size = new System.Drawing.Size(92, 28);
            this.upDownHL2.TabIndex = 19;
            this.upDownHL2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upDownHL1
            // 
            this.upDownHL1.Location = new System.Drawing.Point(289, 202);
            this.upDownHL1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownHL1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownHL1.Name = "upDownHL1";
            this.upDownHL1.Size = new System.Drawing.Size(92, 28);
            this.upDownHL1.TabIndex = 18;
            this.upDownHL1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(95, 270);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(188, 20);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "Number of neurons in HL3:";
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(95, 241);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(188, 20);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "Number of neurons in HL2:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of neurons in HL1:";
            // 
            // upDownHL
            // 
            this.upDownHL.Location = new System.Drawing.Point(289, 161);
            this.upDownHL.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.upDownHL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownHL.Name = "upDownHL";
            this.upDownHL.Size = new System.Drawing.Size(92, 28);
            this.upDownHL.TabIndex = 14;
            this.upDownHL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownHL.ValueChanged += new System.EventHandler(this.UpDownHL_ValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of hidden layers:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Error:";
            // 
            // upDownError
            // 
            this.upDownError.DecimalPlaces = 5;
            this.upDownError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.upDownError.Location = new System.Drawing.Point(289, 35);
            this.upDownError.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.upDownError.Name = "upDownError";
            this.upDownError.Size = new System.Drawing.Size(92, 28);
            this.upDownError.TabIndex = 23;
            this.upDownError.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Learning rate:";
            // 
            // upDownLearningRate
            // 
            this.upDownLearningRate.DecimalPlaces = 5;
            this.upDownLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.upDownLearningRate.Location = new System.Drawing.Point(289, 72);
            this.upDownLearningRate.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.upDownLearningRate.Name = "upDownLearningRate";
            this.upDownLearningRate.Size = new System.Drawing.Size(92, 28);
            this.upDownLearningRate.TabIndex = 25;
            this.upDownLearningRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Number of neurons in IL:";
            // 
            // upDownIL
            // 
            this.upDownIL.Location = new System.Drawing.Point(289, 125);
            this.upDownIL.Name = "upDownIL";
            this.upDownIL.Size = new System.Drawing.Size(92, 28);
            this.upDownIL.TabIndex = 27;
            this.upDownIL.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.Location = new System.Drawing.Point(46, 308);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(123, 32);
            this.btnCreateNew.TabIndex = 28;
            this.btnCreateNew.Text = "Create new";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.CreateNew_Click);
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 377);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.upDownIL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upDownLearningRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upDownError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.upDownHL3);
            this.Controls.Add(this.upDownHL2);
            this.Controls.Add(this.upDownHL1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upDownHL);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Configure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.Configure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownIL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown upDownHL3;
        private System.Windows.Forms.NumericUpDown upDownHL2;
        private System.Windows.Forms.NumericUpDown upDownHL1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown upDownHL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDownError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown upDownLearningRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown upDownIL;
        private System.Windows.Forms.Button btnCreateNew;
    }
}