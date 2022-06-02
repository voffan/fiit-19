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
    public partial class ChangeMotherboard : Form
    {
        int MBId;
        string name, manu;
        public ChangeMotherboard(int _mb, string _name, string _manu)
        {
            InitializeComponent();
            MBId = _mb;
            name = _name;
            manu = _manu;
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
                    MotherboardLogic.Change(textBox1.Text, textBox2.Text, MBId);
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

        private void ChangeMotherboard_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = manu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
