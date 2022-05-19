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
    public partial class ChangeEmployee : Form
    {

        readonly object emplId;
        public ChangeEmployee(object _empl)
        {
            InitializeComponent();
            emplId = _empl;       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = (int)comboBox1.SelectedValue;
            EmployeeLogic.EmployeeChange(name, id, emplId);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeEmployee_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                comboBox1.DataSource = (from dep in c.Departments select new { dep.Id, Name = dep.Name + ", " + dep.Id + " отдел" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }


    }
}
