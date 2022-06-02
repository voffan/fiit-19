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
        readonly int depId;
        string name;
        public ChangeDepartment(int _dep, string _name)
        {
            InitializeComponent();
            depId = _dep;
            name = _name;
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
                    DepartmentLogic.DepartmentChange(dname, depId);
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

        private void ChangeDepartment_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
        }

    }
}
