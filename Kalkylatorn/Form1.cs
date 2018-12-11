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
        /*UpdateDisplay funktionen ser till att rätt tal står på rätt plats efter varje knapptryck
        och skriver nollor där det inte finns något nummer*/
        private void UpdateDisplay()
        {
            if (stack.Count > 0)
            {
                stackL1.Text = stack[0].ToString();
            }
            else
            {
                stackL1.Text = "0";
            }
            if (stack.Count > 1)
            {
                stackL2.Text = stack[1].ToString();
            }
            else
            {
                stackL2.Text = "0";
            }
            if (stack.Count > 2)
            {
                stackL3.Text = stack[2].ToString();
            }
            else
            {
                stackL3.Text = "0";
            }
        }

        /*Backspace funktionen nedan har en if-sats som kollar om texten i rutan längst ned har fler än
        * 1 tecken och tar då bort det sista tecknet. Annars byter den tecknet mot en nolla*/
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (stackL1.Text.Length > 1)
            {
                stack[0] = (stack[0] - stack[0] % 10) / 10;
                UpdateDisplay();
            }
            else
            {
                stack[0] = 0;
                UpdateDisplay();
            }
        }
        //tar bort alla nummer i listan
        private void btnCE_Click(object sender, EventArgs e)
        {
            stack.Clear();
            UpdateDisplay();
        }
        //byter numret längst ned till 0
        private void btnC_Click(object sender, EventArgs e)
        {
            stack[0] = 0;
            UpdateDisplay();
        }
        //multiplicerar talet längste ned med -1 för att ändra tecknet framför
        private void btnPM_Click(object sender, EventArgs e)
        {
            stack[0] *= -1;
            UpdateDisplay();
        }
        //tar kvadratroten ur talet längst ned
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            if (stack[0] > 0)
            {
                stack[0] = Math.Sqrt(stack[0]);
                UpdateDisplay();
            }
            else
            {
                stackL1.Text = "Error";
            }
        }
        /*Denna funktion nyttjas av alla nummerknappar och skriver det nummer som syns på knappen man trycker på*/
        private void numbtn_Click(object sender, EventArgs e)
        {
            if (stackL1.Text == "Error")
            {
                stackL1.Text = "0";
            }
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
            if (stackL1.Text != "0" || stackL1.Text[stackL1.Text.Length - 1] == ',') // If-satsen hindrar att man kan fylla textrutan med bara nollor
            {
                stackL1.Text += "0";
                stack[0] = double.Parse(stackL1.Text);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!stackL1.Text.Contains(','))
            {
                stackL1.Text += ",";
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (stack.Count == 0)
            {
                return;
            }
            if (stack.Count == 1)
            {
                stack.Add(0);
            }

            if (sender as Button == btnPlus && stack.Count > 1)
            {
                stack[0] += stack[1];
            }
            else if (sender as Button == btnDiv && stack.Count > 1 && stack[0] != 0)
            {
                stack[0] = stack[1] / stack[0];
            }
            else if (sender as Button == btnGgr && stack.Count > 1)
            {
                stack[0] *= stack[1];
            }
            else if (sender as Button == btnMinus && stack.Count > 1)
            {
                stack[0] = stack[1] - stack[0];
            }
            else if (sender as Button == btnPow && stack.Count > 1)
            {
                stack[0] = Math.Pow(stack[1], stack[0]);
            }
            else
            {
                stackL1.Text = "Error";
                stack.RemoveAt(1);
                return;
            }

            stack.RemoveAt(1);
            UpdateDisplay();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            stack[0] = 1 / stack[0];
            UpdateDisplay();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            stack[0] = Math.Pow(stack[0], stack[1]);
            stack.RemoveAt(1);
            UpdateDisplay();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            stack.Insert(0, 0); //Skapar en tom plats i början av listan där nästa tal kommer matas in
            UpdateDisplay();
        }
    }
}
