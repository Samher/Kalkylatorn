using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylatorn
{
    public partial class Form1 : Form
    {
        string displayTxt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (displayTxt.Length > 1 && displayTxt != "0")
            {
                displayTxt = displayTxt.Remove(displayTxt.Length - 1, 1);
                displayLabel.Text = displayTxt; 
            }
            else
            {
                displayTxt = "";
                displayLabel.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            displayTxt = "";
            displayLabel.Text = "0"; //Denna rad finns i (nästan) alla funktioner, och uppdaterar textrutan i kalkylatorn

        }

        private void btnPM_Click(object sender, EventArgs e)
        {

        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {

        }

        private void numbtn_Click(object sender, EventArgs e)
        {
            displayTxt += (sender as Button).Text;
            displayLabel.Text = displayTxt;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (displayTxt != "") // If-satsen hindrar att man kan skriva ut nollor innan ens tal
            {
                displayTxt += "0";
                displayLabel.Text = displayTxt;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnGgr_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }

        private void btnEq_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnPct_Click(object sender, EventArgs e)
        {

        }
    }
}
