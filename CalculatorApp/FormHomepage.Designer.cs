namespace CalculatorApp
{
    partial class FormHomepage
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
            this.ButtonCalculator = new System.Windows.Forms.Button();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCalculator
            // 
            this.ButtonCalculator.Location = new System.Drawing.Point(386, 103);
            this.ButtonCalculator.Name = "ButtonCalculator";
            this.ButtonCalculator.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalculator.TabIndex = 0;
            this.ButtonCalculator.Text = "Calculator";
            this.ButtonCalculator.UseCompatibleTextRendering = true;
            this.ButtonCalculator.UseVisualStyleBackColor = true;
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Location = new System.Drawing.Point(386, 258);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(75, 23);
            this.ButtonAbout.TabIndex = 1;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.ButtonCalculator);
            this.Name = "FormHomepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculator;
        private System.Windows.Forms.Button ButtonAbout;
    }
}

