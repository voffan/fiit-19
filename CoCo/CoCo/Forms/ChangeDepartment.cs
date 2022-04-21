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
    public partial class ChangeDepartment : Form
    {
        object depId;
        public ChangeDepartment(object _dep)
        {
            InitializeComponent();
            depId = _dep;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DepartmentLogic.DepartmentChange(name, depId);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
