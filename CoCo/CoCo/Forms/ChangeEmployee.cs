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

        object emplId;
        public ChangeEmployee(object _empl)
        {
            InitializeComponent();
            emplId = _empl;       
        }

        private void ChangeEmployees_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = Convert.ToInt32(textBox2.Text);
            EmployeeLogic.EmployeeChange(name, id, emplId);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
