using CoCo.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class AddPer : Form
    {
        public AddPer()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                if (textBox1.Text.Length > 300)
                {
                    Messages.TooLong(label1.Text);
                    return;
                }
                if (textBox2.Text.Length > 300)
                {
                    Messages.TooLong(label2.Text);
                    return;
                }
                try
                {
                    PeripheralLogic.Add(textBox1.Text, textBox2.Text, (int)comboBox1.SelectedValue);
                    Close();
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

        private void AddPer_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                comboBox1.DataSource = (from em in c.Employees select new { em.Id, Name = em.FullName + ", " + em.DepartmentId + " отдел" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
