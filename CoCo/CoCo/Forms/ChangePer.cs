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
            Status status = (Status)Enum.Parse(typeof(Status), (string)comboBox2.SelectedValue);
            string invn = textBox3.Text;
            Close();
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
                //int empl_id = comboBox1.SelectedValue;
                try
                {
                    PeripheralLogic.Change(textBox1.Text, textBox2.Text, (int)comboBox1.SelectedValue, perId, status, invn);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            comboBox2.DataSource = new BindingSource(DescriptionAttributes<Status>.RetrieveAttributes(), null);
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";
            comboBox2.SelectedIndex = (int)status;
            textBox3.Text = invn;
        }
    }
}
