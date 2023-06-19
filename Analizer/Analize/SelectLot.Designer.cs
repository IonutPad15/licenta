namespace Analizer
{
    partial class SelectLot
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
            this.btnAntrenamentRaw = new System.Windows.Forms.Button();
            this.btnTestareNorm = new System.Windows.Forms.Button();
            this.btnAntrenamentNorm = new System.Windows.Forms.Button();
            this.btnTestareRaw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAntrenamentRaw
            // 
            this.btnAntrenamentRaw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAntrenamentRaw.Location = new System.Drawing.Point(50, 47);
            this.btnAntrenamentRaw.Name = "btnAntrenamentRaw";
            this.btnAntrenamentRaw.Size = new System.Drawing.Size(235, 39);
            this.btnAntrenamentRaw.TabIndex = 0;
            this.btnAntrenamentRaw.Text = "Training Raw";
            this.btnAntrenamentRaw.UseVisualStyleBackColor = false;
            this.btnAntrenamentRaw.Click += new System.EventHandler(this.btnAntrenamentRaw_Click);
            // 
            // btnTestareNorm
            // 
            this.btnTestareNorm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTestareNorm.Location = new System.Drawing.Point(50, 259);
            this.btnTestareNorm.Name = "btnTestareNorm";
            this.btnTestareNorm.Size = new System.Drawing.Size(235, 39);
            this.btnTestareNorm.TabIndex = 1;
            this.btnTestareNorm.Text = "Testing Normalized";
            this.btnTestareNorm.UseVisualStyleBackColor = false;
            this.btnTestareNorm.Click += new System.EventHandler(this.btnTestareNorm_Click);
            // 
            // btnAntrenamentNorm
            // 
            this.btnAntrenamentNorm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAntrenamentNorm.Location = new System.Drawing.Point(50, 124);
            this.btnAntrenamentNorm.Name = "btnAntrenamentNorm";
            this.btnAntrenamentNorm.Size = new System.Drawing.Size(235, 39);
            this.btnAntrenamentNorm.TabIndex = 2;
            this.btnAntrenamentNorm.Text = "Training Normalized";
            this.btnAntrenamentNorm.UseVisualStyleBackColor = false;
            this.btnAntrenamentNorm.Click += new System.EventHandler(this.btnAntrenamentNorm_Click);
            // 
            // btnTestareRaw
            // 
            this.btnTestareRaw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTestareRaw.Location = new System.Drawing.Point(50, 192);
            this.btnTestareRaw.Name = "btnTestareRaw";
            this.btnTestareRaw.Size = new System.Drawing.Size(235, 39);
            this.btnTestareRaw.TabIndex = 3;
            this.btnTestareRaw.Text = "Testing Raw";
            this.btnTestareRaw.UseVisualStyleBackColor = false;
            this.btnTestareRaw.Click += new System.EventHandler(this.btnTestareRaw_Click);
            // 
            // SelectLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 359);
            this.Controls.Add(this.btnTestareRaw);
            this.Controls.Add(this.btnAntrenamentNorm);
            this.Controls.Add(this.btnTestareNorm);
            this.Controls.Add(this.btnAntrenamentRaw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SelectLot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectLot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAntrenamentRaw;
        private System.Windows.Forms.Button btnTestareNorm;
        private System.Windows.Forms.Button btnAntrenamentNorm;
        private System.Windows.Forms.Button btnTestareRaw;
    }
}