using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    // 3 references | 0 changes | 0 authors, 0 changes 
    public partial class FormHomepage : Form
    {
        FormAbout formAbout;
        FormCalculator formCalculator;
        // 1 reference | 0 changes | 0 authors, 0 changes
        public FormHomepage()
        {
            InitializeComponent();
            formAbout = new FormAbout();
            formAbout.Visible = false;
            formCalculator = new FormCalculator();
            formCalculator.Visible = false;
        }
        // 1 reference | 0 changes | 0 authors, 0 changes
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            if (formAbout.Visible == true)
                formAbout.Visible = false;
            else
                formAbout.Visible = true;


        }

        // 1 reference | 0 changes | 0 authors, 0 changes
        private void ButtonCalculator_Click(object sender, EventArgs e)
        { 
            if (formCalculator.Visible == true)
                formCalculator.Visible = false;
            else
                formCalculator.Visible = true;

        }
    }
}
