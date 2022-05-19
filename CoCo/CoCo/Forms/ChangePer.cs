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
    public partial class ChangePer : Form
    {
        readonly int perId;
        public ChangePer(int _per)
        {
            InitializeComponent();
            perId = _per;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu = textBox2.Text;
            int empl = (int)comboBox1.SelectedValue;
            PeripheralLogic.PeripheralChange(name, manu, empl, perId);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePer_Load(object sender, EventArgs e)
        {

            using (Context c = new Context())
            {
                comboBox1.DataSource = (from em in c.Employees select new { em.Id, Name = em.FullName + ", " + em.DepartmentId + " отдел" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }
    }
}
