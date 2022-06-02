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
    public partial class ChangeCpu : Form
    {
        int cpuId;
        string name, freq, manu;
        public ChangeCpu(int _cpu, string _name, string _freq, string _manu)
        {
            InitializeComponent();
            cpuId = _cpu;
            name = _name;
            freq = _freq;
            manu = _manu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Length > 300)
            {
                Messages.TooLong(label_name.Text);
                return;
            }
            if (textBoxManu.Text.Length > 300)
            {
                Messages.TooLong(label_name.Text);
                return;
            }
            string name = textBoxName.Text;
            string manu = textBoxManu.Text;
            try
            {
                decimal freq = Convert.ToDecimal(textBoxFreq.Text);
                if(freq < 0 || freq > 30)
                {
                    Messages.WrongFormat(label_freq.Text);
                    return;
                }
                try
                {
                    CpuLogic.Change(name, freq, manu, cpuId);
                }
                catch (Exception ex)
                {
                    Messages.ServerError();
                }
            }
            catch(FormatException ex)
            {
                Messages.WrongFormat(label_freq.Text);
            }
            
            Close();
        }

        private void ChangeCpu_Load(object sender, EventArgs e)
        {
            textBoxName.Text = name;
            textBoxFreq.Text = freq;
            textBoxManu.Text = manu;
        }
    }
}
