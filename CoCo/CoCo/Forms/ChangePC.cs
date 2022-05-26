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

    public partial class ChangePC : Form
    {
        readonly int pcId;
        public ChangePC(int _pc)
        {
            InitializeComponent();
            pcId = _pc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hdd = (int)comboBox1.SelectedValue;
            int cpu = (int)comboBox2.SelectedValue;
            int motherboard = (int)comboBox3.SelectedValue;
            int empl = (int)comboBox4.SelectedValue;
            PCLogic.PCChange(hdd, cpu, motherboard, empl, pcId);
            Close();
        }

        private void ChangePC_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                comboBox1.DataSource = (from hdd in c.Hdds select new { hdd.Id, Name = hdd.Name + " " + hdd.Manufacturer + " " + hdd.Volume + "ГБ" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";

                comboBox2.DataSource = (from cpu in c.Cpus select new { cpu.Id, Name = cpu.Name + " " + cpu.Manufacturer + " " + cpu.Frequency }).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";

                comboBox3.DataSource = (from mth in c.Motherboards select new { mth.Id, Name = mth.Name + " " + mth.Manufacturer }).ToList();
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";

                comboBox4.DataSource = (from em in c.Employees select new { em.Id, Name = em.FullName + ", " + em.DepartmentId + " отдел" }).ToList();
                comboBox4.DisplayMember = "Name";
                comboBox4.ValueMember = "Id";
            }
        }
    } 
}

