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
    public partial class AddDepartment : Form
    {
      
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length > 300)
                {
                    Messages.TooLong(label2.Text);
                    return;
                }
                //добавить обработку ошибок
                String dname = textBox1.Text;
                try
                {
                    DepartmentLogic.DepartmentAdd(dname);
                    Close();
                }
                catch (Exception ex)
                {
                    Messages.ServerError();
                }
                
                Close();
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
    }
}
