using SiliconValley.Список_сотрудников;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_сотрдников
{
    public partial class List_employees : Form
    {
        public List_employees()
        {
            InitializeComponent();
        }
        private void List_employees_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                gridGenre.DataSource = context.Employees.ToList();
            }
        }
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Form_employees form_Employee = new Form_employees("Добавить сотрудника", "Добавить");
            form_Employee.ShowDialog();

            var db = new Context();
            gridGenre.DataSource = db.Employees.ToList();
        }

        private void ChangeEmployee_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridGenre.CurrentRow.Cells[0].Value);
            Form_employees form_Employee = new Form_employees("Изменить данные сотрудника", "Изменить",id);
            form_Employee.ShowDialog();

            var db = new Context();
            gridGenre.DataSource = db.Employees.ToList();
        }
    }
}
