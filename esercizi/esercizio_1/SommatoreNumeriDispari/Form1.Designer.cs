namespace SommatoreNumeriDispari {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            nmMin = new NumericUpDown();
            lbInserisciNumero = new Label();
            lbResult = new Label();
            btCalculate = new Button();
            nmMax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmMax).BeginInit();
            SuspendLayout();
            // 
            // nmMin
            // 
            nmMin.Location = new Point(164, 80);
            nmMin.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nmMin.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            nmMin.Name = "nmMin";
            nmMin.Size = new Size(129, 23);
            nmMin.TabIndex = 0;
            // 
            // lbInserisciNumero
            // 
            lbInserisciNumero.AutoSize = true;
            lbInserisciNumero.Location = new Point(145, 46);
            lbInserisciNumero.Name = "lbInserisciNumero";
            lbInserisciNumero.Size = new Size(337, 15);
            lbInserisciNumero.TabIndex = 1;
            lbInserisciNumero.Text = "Define the minimum and maximum range (left min right max)";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(316, 175);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(13, 15);
            lbResult.TabIndex = 2;
            lbResult.Text = "0";
            // 
            // btCalculate
            // 
            btCalculate.Location = new Point(254, 128);
            btCalculate.Name = "btCalculate";
            btCalculate.Size = new Size(129, 23);
            btCalculate.TabIndex = 3;
            btCalculate.Text = "Calculate";
            btCalculate.UseVisualStyleBackColor = true;
            btCalculate.Click += btCalculate_Click;
            // 
            // nmMax
            // 
            nmMax.Location = new Point(333, 80);
            nmMax.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nmMax.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            nmMax.Name = "nmMax";
            nmMax.Size = new Size(129, 23);
            nmMax.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 227);
            Controls.Add(nmMax);
            Controls.Add(btCalculate);
            Controls.Add(lbResult);
            Controls.Add(lbInserisciNumero);
            Controls.Add(nmMin);
            Name = "Form1";
            Text = "Odd Numbers Adder";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmMin;
        private Label lbInserisciNumero;
        private Label lbResult;
        private Button btCalculate;
        private NumericUpDown nmMax;
    }
}