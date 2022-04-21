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
    public partial class AddPer : Form
    {
        public AddPer()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeripheralLogic.Add(textBox1.Text, textBox2.Text, (int)comboBox4.SelectedValue);
            Close();
        }

        private void AddPer_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                comboBox4.DataSource = (from em in c.Employees select new { Id = em.Id, Name = em.FullName + " " + em.DepartmentId + " отдел" }).ToList();
                comboBox4.DisplayMember = "Name";
                comboBox4.ValueMember = "Id";
                // comboBox1.Items.Add((from em in c.Employees select new { Id = em.Id, Name = em.FullName + " " + em.DepartmentId + "отдел" }).ToList()[i).Name;
            }
        }
    }
}
