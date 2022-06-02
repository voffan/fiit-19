using CoCo.Classes;
using System;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class AddHdd : Form
    {

        public AddHdd()
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
                    decimal volume = Convert.ToDecimal(textBox2.Text);
                    if (volume < 0 || volume > 2000)
                    {
                        Messages.WrongFormat(label2.Text);
                        return;
                    }
                    try
                    {
                        HddLogic.Add(textBox1.Text, volume, textBox3.Text);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        Messages.ServerError();
                    }

                }
                catch (FormatException ex)
                {
                    Messages.WrongFormat(label2.Text);
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
