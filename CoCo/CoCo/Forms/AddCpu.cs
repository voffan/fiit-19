using CoCo.Classes;
using System;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class AddCpu : Form
    {
        public AddCpu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox1.Text.Length > 300)
                {
                    Messages.TooLong(label1.Text);
                    return;
                }
                if (textBox3.Text.Length > 300)
                {
                    Messages.TooLong(label3.Text);
                    return;
                }
                try
                {
                    decimal freq = Convert.ToDecimal(textBox2.Text);
                    if (freq < 0 || freq > 30)
                    {
                        Messages.WrongFormat(label4.Text);
                        return;
                    }
                    try
                    {
                        CpuLogic.Add(textBox1.Text, freq, textBox3.Text);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        Messages.ServerError();
                    }

                }
                catch (FormatException ex)
                {
                    Messages.WrongFormat(label4.Text);
                }
            }
            else
            {
                Messages.Empty();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
