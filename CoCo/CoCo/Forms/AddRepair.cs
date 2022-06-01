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
    public partial class AddRepair : Form
    {
        readonly List<int> ids;
        public AddRepair(List<int> ids)
        {
            InitializeComponent();
            this.ids = ids;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                for (int i = 0; i < ids.Count; i++)
                {
                        RepairLogic.Add(ids[i], textBox1.Text);
                        DeviceLogic.ChangeStatus(ids[i], Status.repairing);
                        Close();
                }
            else
                Messages.Empty();
        }
    }
}
