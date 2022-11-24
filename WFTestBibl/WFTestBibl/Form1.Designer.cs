namespace MasterThesisApp
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MovAv = new System.Windows.Forms.Button();
            this.MedF = new System.Windows.Forms.Button();
            this.SavGol = new System.Windows.Forms.Button();
            this.Kal = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.xButton = new System.Windows.Forms.RadioButton();
            this.yButton = new System.Windows.Forms.RadioButton();
            this.zButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nineButton = new System.Windows.Forms.RadioButton();
            this.sevenButton = new System.Windows.Forms.RadioButton();
            this.fiveButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 363);
            this.textBox1.TabIndex = 2;
            // 
            // MovAv
            // 
            this.MovAv.Location = new System.Drawing.Point(24, 84);
            this.MovAv.Name = "MovAv";
            this.MovAv.Size = new System.Drawing.Size(132, 23);
            this.MovAv.TabIndex = 4;
            this.MovAv.Text = "Moving Average";
            this.MovAv.UseVisualStyleBackColor = true;
            this.MovAv.Click += new System.EventHandler(this.MovAv_Click);
            // 
            // MedF
            // 
            this.MedF.Location = new System.Drawing.Point(24, 149);
            this.MedF.Name = "MedF";
            this.MedF.Size = new System.Drawing.Size(132, 23);
            this.MedF.TabIndex = 5;
            this.MedF.Text = "Median";
            this.MedF.UseVisualStyleBackColor = true;
            this.MedF.Click += new System.EventHandler(this.MedF_Click);
            // 
            // SavGol
            // 
            this.SavGol.Location = new System.Drawing.Point(194, 84);
            this.SavGol.Name = "SavGol";
            this.SavGol.Size = new System.Drawing.Size(132, 23);
            this.SavGol.TabIndex = 6;
            this.SavGol.Text = "Savitzky-Golay";
            this.SavGol.UseVisualStyleBackColor = true;
            this.SavGol.Click += new System.EventHandler(this.SavGol_Click);
            // 
            // Kal
            // 
            this.Kal.Location = new System.Drawing.Point(194, 149);
            this.Kal.Name = "Kal";
            this.Kal.Size = new System.Drawing.Size(132, 23);
            this.Kal.TabIndex = 7;
            this.Kal.Text = "Kalman";
            this.Kal.UseVisualStyleBackColor = true;
            this.Kal.Click += new System.EventHandler(this.Kal_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(406, 544);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(132, 23);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(406, 407);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(132, 23);
            this.Open.TabIndex = 11;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(406, 479);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(132, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(615, 23);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(828, 563);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // xButton
            // 
            this.xButton.AutoSize = true;
            this.xButton.Location = new System.Drawing.Point(24, 19);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(32, 17);
            this.xButton.TabIndex = 14;
            this.xButton.Text = "X";
            this.xButton.UseVisualStyleBackColor = true;
            // 
            // yButton
            // 
            this.yButton.AutoSize = true;
            this.yButton.Location = new System.Drawing.Point(24, 62);
            this.yButton.Name = "yButton";
            this.yButton.Size = new System.Drawing.Size(32, 17);
            this.yButton.TabIndex = 15;
            this.yButton.Text = "Y";
            this.yButton.UseVisualStyleBackColor = true;
            // 
            // zButton
            // 
            this.zButton.AutoSize = true;
            this.zButton.Location = new System.Drawing.Point(24, 107);
            this.zButton.Name = "zButton";
            this.zButton.Size = new System.Drawing.Size(32, 17);
            this.zButton.TabIndex = 16;
            this.zButton.Text = "Z";
            this.zButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(140, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(450, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "File";
            // 
            // nineButton
            // 
            this.nineButton.AutoSize = true;
            this.nineButton.Location = new System.Drawing.Point(31, 109);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(31, 17);
            this.nineButton.TabIndex = 21;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            this.sevenButton.AutoSize = true;
            this.sevenButton.Location = new System.Drawing.Point(31, 62);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(31, 17);
            this.sevenButton.TabIndex = 20;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSize = true;
            this.fiveButton.Location = new System.Drawing.Point(31, 19);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(31, 17);
            this.fiveButton.TabIndex = 19;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(379, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Axis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(472, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Frame size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xButton);
            this.groupBox1.Controls.Add(this.yButton);
            this.groupBox1.Controls.Add(this.zButton);
            this.groupBox1.Location = new System.Drawing.Point(370, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 151);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nineButton);
            this.groupBox2.Controls.Add(this.fiveButton);
            this.groupBox2.Controls.Add(this.sevenButton);
            this.groupBox2.Location = new System.Drawing.Point(476, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(82, 151);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 624);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Kal);
            this.Controls.Add(this.SavGol);
            this.Controls.Add(this.MedF);
            this.Controls.Add(this.MovAv);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MovAv;
        private System.Windows.Forms.Button MedF;
        private System.Windows.Forms.Button SavGol;
        private System.Windows.Forms.Button Kal;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton xButton;
        private System.Windows.Forms.RadioButton yButton;
        private System.Windows.Forms.RadioButton zButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton nineButton;
        private System.Windows.Forms.RadioButton sevenButton;
        private System.Windows.Forms.RadioButton fiveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

