using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zavd._1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                string str_a = textBox_a.Text;
                int a = int.Parse(str_a);

                string str_b = textBox_b.Text;
                int b = int.Parse(str_b);

                string str_c = textBox_c.Text;
                int c = int.Parse(str_c);

                if (a == 0)
                {
                    
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Ant.Text = "Нескінченна кількість коренів (рівняння тотожне)";
                        }
                        else
                        {
                            Ant.Text = "Немає рішень (рівняння вироджене)";
                        }
                        Riv.Text = "Результат: " + "0" + "x^2 + " + "0" + "x + " + str_c + " = 0";
                    }
                    else
                    {
                        double x = -c / (double)b;
                        Ant.Text = "Один розв'язок: x = " + x.ToString();
                    }
                    Riv.Text = "Результат: " + " 0" + "x^2 + " + str_b + "x + " + str_c + " = 0";
                }
                else
                {
                    int v = b * b - 4 * a * c;

                    if (v < 0)
                    {
                        Ant.Text = "Немає дійсних коренів (дискримінант негативний)";
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(v)) / (2 * (double)a);
                        double x2 = (-b - Math.Sqrt(v)) / (2 * (double)a);

                        Ant.Text = "Два дійсні корені: x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                    }

                    string D = v.ToString();
                    Riv.Text = "Результат: " + str_a + "x^2 + " + str_b + "x + " + str_c + " = 0";
                    dis.Text = "Дискримінант: " + D;
                }
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некоректне введення. Будь ласка, введіть цілочисельні значення для a, b і c.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
   
}
