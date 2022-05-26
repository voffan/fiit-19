using SiliconValley.Список_Жанров;
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
            this.Name = "list";
        }
        private void List_employees_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                gridEmployee.DataSource = context.Employees.ToList();
                gridEmployee.Columns["Birthday"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }

            //DescriptionViewInTable();
        }
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Form_employees form_Employee = new Form_employees("Добавить сотрудника", "Добавить");
            form_Employee.ShowDialog();

            var db = new Context();
            gridEmployee.DataSource = db.Employees.ToList();
        }

        private void ChangeEmployee_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(gridEmployee.CurrentRow.Cells[0].Value);
            Form_employees form_Employee = new Form_employees("Изменить данные сотрудника", "Изменить",id);
            form_Employee.ShowDialog();

            var db = new Context();
            gridEmployee.DataSource = db.Employees.ToList();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            MessageBoxButtons box = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "", box);

            if (result == DialogResult.No)
                return;

            for (int i = 0; i < gridEmployee.SelectedRows.Count; i++)
            {
                int? currentId = Convert.ToInt32(gridEmployee.SelectedRows[i].Cells[0].Value);
                Employee emp = ListsComponent.GetObjById<Employee>(currentId);

                ListsComponent.Delete(emp);
            }

            using (Context db = new Context())
            {
                gridEmployee.DataSource = db.Employees.ToList();
            }
        }

        void DescriptionViewInTable()
        {
            for (int i = 0; i < gridEmployee.Rows.Count; i++)
            {
                Position pos = (Position)Enum.Parse(typeof(Position), gridEmployee.Rows[i].Cells[5].Value.ToString());
                gridEmployee.Rows[i].Cells[5].Value = "asdsad";

                Education edu = (Education)Enum.Parse(typeof(Education), gridEmployee.Rows[i].Cells[6].Value.ToString());
                //gridEmployee.Rows[i].Cells[6].Value = edu.GetDescription();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                gridEmployee.DataSource = db.Employees.Where(d => d.Surname.Contains(textBox1.Text) || d.Name.Contains(textBox1.Text)).ToList();
            }
        }
    }
}
