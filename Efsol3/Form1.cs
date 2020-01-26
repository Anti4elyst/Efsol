using System;
using System.Windows.Forms;

namespace Efsol3
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
                double ch1 = double.Parse(textBox1.Text);
                double ch2 = double.Parse(textBox2.Text);
                double otvet = ch1 + ch2;
                textBox3.Text = ch1.ToString() + "\r\n" + "+" + "\r\n" + ch2.ToString() + "\r\n" + "________" + "\r\n" + otvet.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double ch1 = double.Parse(textBox1.Text);
                double ch2 = double.Parse(textBox2.Text);
                double otvet = ch1 - ch2;
                textBox3.Text = ch1.ToString() + "\r\n" + "-" + "\r\n" + ch2.ToString() + "\r\n" + "________" + "\r\n" + otvet.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double ch1 = double.Parse(textBox1.Text);
                double ch2 = double.Parse(textBox2.Text);
                double otvet = ch1 * ch2;
                int count1 = BitConverter.GetBytes(decimal.GetBits((decimal)ch1)[3])[2];
                int count2 = BitConverter.GetBytes(decimal.GetBits((decimal)ch2)[3])[2];
                double temp1 = ch1 * Math.Pow(10, count1);
                double temp2 = ch2 * Math.Pow(10, count2);
                if (otvet == 0)
                    textBox3.Text = ch1 + "\r\n" + "*" + "\r\n" + ch2 + "\r\n" + "_______" + "\r\n" + "0";
                else
                textBox3.Text = ch1 + "\r\n" + "*" + "\r\n" + ch2 + "\r\n" + "Домножим до целых" + "\r\n" + temp1 + "\r\n" + "*" + "\r\n" + temp2 + "\r\n" + "________" + "\r\n" + temp2 * temp1 + "\r\n" + "Перенесем запятую" + "\r\n" + "________" + "\r\n" + otvet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
             {
                double ch1 = double.Parse(textBox1.Text);
                double ch2 = double.Parse(textBox2.Text);
                if (ch2==0)
                {
                    MessageBox.Show("Попытка деления на ноль!");
                    return;
                }
                double otvet = ch1 / ch2;
                int count1 = BitConverter.GetBytes(decimal.GetBits((decimal)ch1)[3])[2];
                int count2 = BitConverter.GetBytes(decimal.GetBits((decimal)ch2)[3])[2];
                double temp1 = ch1 * Math.Pow(10, count1);
                double temp2 = ch2 * Math.Pow(10, count2);
                if (temp1 < 0)
                    temp1 = Math.Abs(temp1);
                if (temp2 < 0)
                    temp2 = Math.Abs(temp2);
                string zap = ",";
                double absotvet =otvet;
                if (otvet < 0)
                    absotvet = Math.Abs(absotvet);
                string str = absotvet.ToString();
                int z = 1;
            if (str.Length != 1)
            {
                z = str.Length - 1;
                int index = str.IndexOf(zap);
                str = str.Remove(index, index);
            }
                string b = "";
                foreach (char element in str)
                {
                    b += element + ",";
                }
                for (int i = 0; i < z; i++)
                    textBox4.Text += b;
                string[] sb = textBox4.Text.Split(',');
                int[] a = new int[z];
                for (int i = 0; i < z; i++)
                {
                    a[i] = int.Parse(sb[i]);
                    textBox5.Text += a[i] + " ";
                }
                int k = 0;
                foreach (char c in ch1.ToString())
                {
                    k++;
                }
                textBox3.Text += ch1.ToString() + " ║";
                textBox3.Text += ch2.ToString() + "\r\n";
                for (int i = 0; i < k; i++)
                {
                    textBox3.Text += "  ";
                }
                textBox3.Text += "╠════════" + "\r\n";
                for (int i = 0; i < k; i++)
                {
                    textBox3.Text += "  ";
                }
                textBox3.Text += otvet.ToString() + "\r\n" + "\r\n";
                for (int i = 0; i < z; i++)
                {
                    while (temp1 < temp2)
                    {
                        temp1 *= 10;
                    }
                    double x = temp1 - temp2 * a[i];
                    textBox3.Text += temp1 + "\r\n" + "-" + "\r\n" + (temp2 * a[i]) + "\r\n" + "________" + "\r\n" + x + "\r\n";
                    temp1 -= temp2 * a[i];
                }
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
