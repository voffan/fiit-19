using CoCo.Classes;
using System;
using System.Windows.Forms;

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
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                if (textBox1.Text.Length > 300)
                {
                    Messages.TooLong(label1.Text);
                    return;
                }
                if (textBox2.Text.Length > 300)
                {
                    Messages.TooLong(label2.Text);
                    return;
                }
                try
                {
                    MotherboardLogic.Add(textBox1.Text, textBox2.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    Messages.ServerError();
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
