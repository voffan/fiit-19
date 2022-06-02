using CoCo.Classes;
using System;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class ChangeHdd : Form
    {
        int hddId;
        string name, vol, manu;
        public ChangeHdd(int _hdd, string _name, string _vol, string _manu)
        {
            InitializeComponent();
            hddId = _hdd;
            name = _name;
            vol = _vol;
            manu = _manu;
        }

        private void ChangeHdd_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = vol;
            textBox3.Text = manu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                        HddLogic.Change(textBox1.Text, volume, textBox3.Text, hddId);
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
