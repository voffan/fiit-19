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
   
    public partial class AddMotherboard : Form
    {
        public AddMotherboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 )
            {
                if (textBox1.Text.Length > 300)
                {
                    Messages.TooLong(label1.Text);
                }
                else if (textBox2.Text.Length > 300)
                {
                    Messages.TooLong(label2.Text);
                }
                else try
                    {
                        MotherboardLogic.Add(textBox1.Text, textBox2.Text);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
            else
            {
                Messages.Empty();
            }
        }
    }
}
