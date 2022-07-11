using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestikiNolici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool XO = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.Enabled = false;

            if (XO)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            XO = !XO;

            if (((button1.Text == "X") && (button2.Text == "X") && (button3.Text == "X")) || ((button4.Text == "X") && (button5.Text == "X") && (button6.Text == "X")) || ((button7.Text == "X") && (button8.Text == "X") && (button9.Text == "X")) || ((button1.Text == "X") && (button4.Text == "X") && (button7.Text == "X")) || ((button2.Text == "X") && (button5.Text == "X") && (button8.Text == "X")) || ((button3.Text == "X") && (button6.Text == "X") && (button9.Text == "X")) || ((button1.Text == "X") && (button5.Text == "X") && (button9.Text == "X")) || ((button3.Text == "X") && (button5.Text == "X") && (button7.Text == "X")))
            {
                MessageBox.Show("Победили крестики!");
                XO = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
            else if (((button1.Text == "O") && (button2.Text == "O") && (button3.Text == "O")) || ((button4.Text == "O") && (button5.Text == "O") && (button6.Text == "O")) || ((button7.Text == "O") && (button8.Text == "O") && (button9.Text == "O")) || ((button1.Text == "O") && (button4.Text == "O") && (button7.Text == "O")) || ((button2.Text == "O") && (button6.Text == "O") && (button8.Text == "O")) || ((button3.Text == "O") && (button6.Text == "O") && (button9.Text == "O")) || ((button1.Text == "O") && (button5.Text == "O") && (button9.Text == "O")) || ((button3.Text == "O") && (button5.Text == "O") && (button7.Text == "O")))
            {
                MessageBox.Show("Победили нолики!");
                XO = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
            else if ((button1.Enabled == false) && (button2.Enabled == false) && (button3.Enabled == false) && (button4.Enabled == false) && (button5.Enabled == false) && (button6.Enabled == false) && (button7.Enabled == false) && (button8.Enabled == false) && (button9.Enabled == false))
            { 
                MessageBox.Show("Ничья!");
                XO = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
               
            }
        }
    }
}
