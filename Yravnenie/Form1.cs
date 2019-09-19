using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yravnenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            double a, b, c, d, x1, x2, num;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                d = (b * b) - (4 * a * c);

                if (b == 0 & c == 0 || a==0)
                {
                    MessageBox.Show("Недопустимые значения");
                }

                else if (b == 0 & c != 0)
                {
                    num = -c / a;

                    if (num > 0)
                    {
                        label7.Text = ("X1 = " + Math.Round(-Math.Sqrt(num), 3) + ", X2 = " + Math.Round(Math.Sqrt(num), 3));
                    }
                    else
                    {
                        MessageBox.Show("Корней нет");
                    }
                }

                else if (b != 0 & c == 0)
                {
                    num = -b / a;
                    label7.Text = ("X1 = 0, "+"X2 = "+num);
                }

                else if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    label7.Text = ("X1 = " + Math.Round(x1, 3) + ", X2 = " + Math.Round(x2, 3));

                }
                else if (d == 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    label7.Text = ("X1 = " + Math.Round(x1,3));
                }
                else if (d < 0)
                {
                    MessageBox.Show("Корней нет");
                }
            }
            catch (Exception) {
                MessageBox.Show("Введено неверное значение");
            }
            
            
        }
    }
}
