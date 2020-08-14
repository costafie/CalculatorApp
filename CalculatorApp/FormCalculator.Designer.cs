namespace CalculatorApp
{
    partial class FormCalculator
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
            this.labelformCalculator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelformCalculator
            // 
            this.labelformCalculator.AutoSize = true;
            this.labelformCalculator.Location = new System.Drawing.Point(367, 199);
            this.labelformCalculator.Name = "labelformCalculator";
            this.labelformCalculator.Size = new System.Drawing.Size(37, 13);
            this.labelformCalculator.TabIndex = 0;
            this.labelformCalculator.Text = "1+1=2";
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelformCalculator);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelformCalculator;
    }
}