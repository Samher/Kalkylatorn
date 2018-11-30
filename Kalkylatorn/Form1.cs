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
        List<double> stack = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateDisplay()
        {
            if (stack.Count > 0)
            {
                stackL1.Text = stack[0].ToString();
            }
            if (stack.Count > 1)
            {
                stackL2.Text = stack[1].ToString();
            }
            if (stack.Count > 2)
            {
                stackL3.Text = stack[2].ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (stackL1.Text.Length > 1 && stackL1.Text != "0")
            {
                stackL1.Text = stackL1.Text.Remove(stackL1.Text.Length - 1, 1);
                UpdateDisplay();
            }
            else
            {
                stackL1.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            stack[0] = 0;
            UpdateDisplay();

        }

        private void btnPM_Click(object sender, EventArgs e)
        {

        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            stackL1.Text = Math.Sqrt(stack[0]).ToString();
            stackL1.Text = stackL1.Text;
        }

        private void numbtn_Click(object sender, EventArgs e)
        {
            if (stackL1.Text == "0")
            {
                stackL1.Text = "";
            }
            stackL1.Text += (sender as Button).Text;
            if (stack.Count == 0)
            {
                stack.Add(double.Parse(stackL1.Text));
            }
            else
            {
                stack[0] = double.Parse(stackL1.Text);
            }
            UpdateDisplay();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (stackL1.Text != "0") // If-satsen hindrar att man kan fylla textrutan med bara nollor
            {
                stackL1.Text += "0";
                UpdateDisplay();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            stackL1.Text = (stack[1] + stack[0]).ToString();
            stackL1.Text = stackL1.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            stackL1.Text = (stack[1] - stack[0]).ToString();
            stackL1.Text = stackL1.Text;
        }

        private void btnGgr_Click(object sender, EventArgs e)
        {
            stackL1.Text = (stack[1] * stack[0]).ToString();
            stackL1.Text = stackL1.Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            stackL1.Text = (stack[1] / stack[0]).ToString();
            stackL1.Text = stackL1.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnPct_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            stack.Insert(0, 0); //Skapar en tom plats i början av listan där nästa tal kommer matas in
            UpdateDisplay();
        }
    }
}
