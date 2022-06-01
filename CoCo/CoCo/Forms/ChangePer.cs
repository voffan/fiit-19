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
        readonly int perId, eId;
        Status status;
        string invn;
        public ChangePer(int _per)
        {
            InitializeComponent();
            perId = _per;
            Peripheral per = PeripheralLogic.Get(_per);
            eId = per.EmployeeId;
            status = per.Status;
            invn = per.InventoryNumber;
            textBox1.Text = per.Name;
            textBox2.Text = per.Manufacturer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu = textBox2.Text;
            int empl = (int)comboBox1.SelectedValue;
            Status status = (Status)comboBox2.SelectedItem;
            string invn = textBox3.Text;
            PeripheralLogic.PeripheralChange(name, manu, empl, perId, status, invn);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = PeripheralLogic.InvNumber(perId);
        }

        private void ChangePer_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                comboBox1.DataSource = (from em in c.Employees select new { em.Id, Name = em.FullName + ", " + em.DepartmentId + " отдел" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox1.SelectedValue = eId;
            }
            comboBox2.DataSource = Enum.GetValues(typeof(Status));
            comboBox2.SelectedItem = status;
            textBox3.Text = invn;
        }
    }
}
