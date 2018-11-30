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
        List<double> stack = new List<double>();
        //double temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (displayTxt.Length > 1 && displayTxt != "0")//Denna if-sats behåller alltid en nolla när man har tagi bort alla siffror
            {
                displayTxt = displayTxt.Remove(displayTxt.Length - 1, 1);
                stackL1.Text = displayTxt;
            }
            else
            {
                displayTxt = "";
                stackL1.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            displayTxt = "";
            stackL1.Text = "0"; //Denna rad finns i (nästan) alla funktioner, och uppdaterar textrutan i kalkylatorn

        }

        private void btnPM_Click(object sender, EventArgs e)
        {

        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            displayTxt = Math.Sqrt(stack[0]).ToString();
            stackL1.Text = displayTxt;
        }

        private void numbtn_Click(object sender, EventArgs e)
        {
            displayTxt += (sender as Button).Text;
            if (stack.Count == 0)
            {
                stack.Add(double.Parse(displayTxt));
            }
            else
            {
                stack[0] = double.Parse(displayTxt);
            }
            stackL1.Text = displayTxt;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (displayTxt != "") // If-satsen hindrar att man kan fylla textrutan med bara nollor
            {
                displayTxt += "0";
                stackL1.Text = displayTxt;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            displayTxt = (stack[1] + stack[0]).ToString();// Alla rader som ser ut såhär med olika operatorer utför den aktuella beräkningen
            stackL1.Text = displayTxt;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            displayTxt = (stack[1] - stack[0]).ToString();
            stackL1.Text = displayTxt;
        }

        private void btnGgr_Click(object sender, EventArgs e)
        {
            displayTxt = (stack[1] * stack[0]).ToString();
            stackL1.Text = displayTxt;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            displayTxt = (stack[1] / stack[0]).ToString();
            stackL1.Text = displayTxt;
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
            stackL3.Text = stackL2.Text;
            stackL2.Text = stackL1.Text;
            stackL1.Text = "0";
            displayTxt = ""; //De senaste 4 raderna sköter uppskjutningen av texten i rutorna
        }

        private void stackL3_Click(object sender, EventArgs e)
        {

        }
    }
}
