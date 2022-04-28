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
                    Messages.TooLong("Название");
                }
                else if (textBox3.Text.Length > 300)
                {
                    Messages.TooLong("Название производителя");
                }
                else
                {
                    try
                    {
                        decimal freq = Convert.ToDecimal(textBox2.Text);
                        if (freq < 0 || freq > 30)
                        {
                            Messages.WrongFormat("Частота");
                        }
                        else
                        {
                            try
                            {
                                CpuLogic.Add(textBox1.Text, freq, textBox3.Text);
                                Close();
                            }
                            catch
                            {
                                Messages.ServerError();
                            }
                        }

                    }
                    catch
                    {
                        Messages.WrongFormat("Частота");
                    }
                }
            }
            else
            {
                Messages.Empty();
            }
        }
    }
}
