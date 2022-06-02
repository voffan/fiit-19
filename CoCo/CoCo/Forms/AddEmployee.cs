using CoCo.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class AddEmployee : Form
    {

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && comboBox1.Text.Length > 0)
            {
                string Name = textBox1.Text;
                if (Name.Length > 300)
                {
                    Messages.TooLong(label2.Text);
                    return;
                }
                try
                {
                    int Id = (int)comboBox1.SelectedValue;
                    EmployeeLogic.EmployeeAdd(Name, Id);
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

        private void AddEmployee_Load(object sender, EventArgs e)
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
