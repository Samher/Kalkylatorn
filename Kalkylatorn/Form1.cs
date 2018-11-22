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
            displayLabel.Text = displayTxt;

        }

        private void btnPM_Click(object sender, EventArgs e)
        {

        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            displayTxt += "1";
            displayLabel.Text = displayTxt;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            displayTxt += "2";
            displayLabel.Text = displayTxt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            displayTxt += "3";
            displayLabel.Text = displayTxt;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            displayTxt += "4";
            displayLabel.Text = displayTxt;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            displayTxt += "5";
            displayLabel.Text = displayTxt;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            displayTxt += "6";
            displayLabel.Text = displayTxt;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            displayTxt += "7";
            displayLabel.Text = displayTxt;
        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

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
