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
        string name;
        int depid;
        public ChangeEmployee(int _empl, string _name, int _depid)
        {
            InitializeComponent();
            emplId = _empl;
            name = _name;
            depid = _depid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && comboBox1.Text.Length > 0)
            {
                string Name = textBox1.Text;
                if (Name.Length > 300)
                {
                    Messages.TooLong(label1.Text);
                    return;
                }
                try
                {
                    int Id = (int)comboBox1.SelectedValue;
                    EmployeeLogic.EmployeeChange(Name, Id, emplId);
                    Close();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
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
                comboBox1.SelectedValue = depid;
            }
        }
    }
}
