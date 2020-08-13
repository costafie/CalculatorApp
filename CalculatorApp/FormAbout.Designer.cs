namespace CalculatorApp
{
    partial class FormAbout
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
            this.LabelAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAbout
            // 
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.Location = new System.Drawing.Point(241, 199);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(266, 13);
            this.LabelAbout.TabIndex = 0;
            this.LabelAbout.Text = "aplicatie calculator creata de constantin in  13.08.2020";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelAbout);
            this.Name = "FormAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAbout;
    }
}