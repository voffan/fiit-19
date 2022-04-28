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
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                string Name = textBox1.Text;
                if (Name.Length > 300)
                    Messages.TooLong("Имя");
                else
                    try
                    {
                        int Id = Convert.ToInt32(textBox2.Text);
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
    }
}
