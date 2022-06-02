using CoCo.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class AddRepair : Form
    {
        readonly List<int> ids;
        public AddRepair(List<int> ids)
        {
            InitializeComponent();
            this.ids = ids;
        }
        public AddRepair(int id)
        {
            InitializeComponent();
            this.ids = new List<int> {id };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Messages.Empty();
                return;
            }
            if (textBox1.Text.Length > 300)
            {
                Messages.TooLong(label1.Text);
                return;
            }
            for (int i = 0; i < ids.Count; i++)
            {
                RepairLogic.Add(ids[i], textBox1.Text);
                DeviceLogic.ChangeStatus(ids[i], Status.repairing);
                
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
