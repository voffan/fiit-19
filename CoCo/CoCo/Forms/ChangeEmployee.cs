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

        readonly int emplId;
        string name, depid;
        public ChangeEmployee(int _empl, string _name)
        {
            InitializeComponent();
            emplId = _empl;
            name = _name;
            //depid = _depid;
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
                textBox1.Text = name;
                comboBox1.DataSource = (from dep in c.Departments select new { dep.Id, Name = dep.Name + ", " + dep.Id + " отдел" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }


    }
}
