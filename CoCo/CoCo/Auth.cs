using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCo
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            Classes.Department d = new Classes.Department();
            d.Name = "Dep";
            context.Departments.Add(d);
            context.SaveChanges();
            Classes.Employee empl = new Classes.Employee();
            empl.FullName = "San";
            string password = "qwerty";
            empl.Department = d;
            context.Employees.Add(empl);
            context.SaveChanges();
            if (textBox1.Text == empl.FullName && textBox2.Text == password)
            {
                Hide();
                new Form1().ShowDialog();
                Close();
            }
            
        }
    }
}
