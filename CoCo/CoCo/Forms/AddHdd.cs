using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoCo.Classes;

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
                }
                else if (textBox3.Text.Length > 300)
                {
                    Messages.TooLong(label3.Text);
                }
                else try
                    {
                        decimal volume = Convert.ToDecimal(textBox2.Text);
                        if (volume < 0 || volume > 2000)
                        {
                            Messages.WrongFormat(label2.Text);
                        }
                        else
                        {
                            try
                            {
                                HddLogic.Add(textBox1.Text, volume, textBox3.Text);
                                Close();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                    }
                    catch ( FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
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
