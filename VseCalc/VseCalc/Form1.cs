using Sprache.Calc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VseCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button17.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button20.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

            button17.Visible = false;
            button18.Visible = false;
            button21.Visible = false;
            button20.Visible = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            label2.Visible = false;
            label1.Visible = false;
        }

        private double Factor(double pick)
        {
            int caunt = Convert.ToInt32(pick);
            double itog = 1;

            for (int i = 1; i <= caunt; i++)
            {
                itog *= i;
            }
            return itog;
        }

        private void End_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled == false && dateTimePicker2.Enabled == false)
            {
                try
                {

                    XtensibleCalculator calc = new XtensibleCalculator().RegisterFunction("F", (pick) => Factor(pick));
                    var func = calc.ParseExpression(InSize.Text).Compile();
                    EndSize.Text = func().ToString();

                    if (radioButton1.Enabled == true && radioButton2.Enabled == true && radioButton3.Enabled == true)
                    {
                        int num = 0;
                        try
                        {
                            if (radioButton1.Enabled == true && radioButton2.Enabled == true && radioButton3.Enabled == true)
                            {

                                var res = calc.ParseExpression(InSize.Text).Compile();

                                num = Convert.ToInt32(res.Invoke());

                                InSize.Text = num.ToString();

                                if (radioButton1.Checked)
                                {
                                    EndSize.Text = Convert.ToString(num, 2).ToString();
                                }
                                else if (radioButton2.Checked)
                                {
                                    EndSize.Text = Convert.ToString(num, 8).ToString();
                                }
                                else if (radioButton3.Checked)
                                {
                                    EndSize.Text = Convert.ToString(num, 10).ToString();
                                }
                                else
                                {
                                    EndSize.Text = Convert.ToString(num, 16).ToString();
                                }
                            }
                            else
                            {
                                EndSize.Text = Convert.ToString(num, 10).ToString();
                            }
                        }
                        catch
                        {
                            EndSize.Text = "Ошибка";
                        }
                    }
                }
                catch
                {
                    EndSize.Text = "Ошибка";
                }
            }
            else if (dateTimePicker1.Enabled == true && dateTimePicker2.Enabled == true)
            {
                try
                {
                    EndSize.Text = (dateTimePicker1.Value - dateTimePicker2.Value).Duration().ToString();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InSize.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InSize.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InSize.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InSize.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InSize.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InSize.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InSize.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InSize.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InSize.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InSize.Text += "(";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InSize.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InSize.Text += ")";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            InSize.Text += "F(";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            InSize.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InSize.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InSize.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            InSize.Text += "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            InSize.Text += "^2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InSize.Text += "^3";
        }
        private void button21_Click(object sender, EventArgs e)
        {
            InSize.Text += "Log(";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            InSize.Text = "";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label6.Text = "Инженерный";

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

            button17.Enabled = true;
            button18.Enabled = true;
            button21.Enabled = true;
            button20.Enabled = true;

            button17.Visible = true;
            button18.Visible = true;
            button21.Visible = true;
            button20.Visible = true;
            
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            label2.Visible = false;
            label1.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label6.Text = "Программист";

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;

            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;

            button17.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button20.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

            button17.Visible = false;
            button18.Visible = false;
            button21.Visible = false;
            button20.Visible = false;

            label2.Visible = false;
            label1.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label6.Text = "";

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

            button17.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button20.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            button17.Visible = false;
            button18.Visible = false;
            button21.Visible = false;
            button20.Visible = false;

            label2.Visible = false;
            label1.Visible = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label6.Text = "Калькулятор дат";

            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;

            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;

            label2.Visible = true;
            label1.Visible = true;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

            button17.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button20.Enabled = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            button17.Visible = false;
            button18.Visible = false;
            button21.Visible = false;
            button20.Visible = false;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу напсиал студент Русецкий Михаил группы П50-3-18");
        }
    }
}