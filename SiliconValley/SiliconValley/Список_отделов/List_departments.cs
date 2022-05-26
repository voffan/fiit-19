using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_отделов
{
    public partial class List_departments : Form
    {
        public List_departments()
        {
            InitializeComponent();
            this.Name = "list";
        }

        private void List_departments_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                dataGridView1.DataSource = context.Departments.ToList();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form_department formDepartment = new Form_department("Добавить отдел", "Добавить");
            formDepartment.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Departments.ToList();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Form_department formDep = new Form_department("Изменить отдел", "Изменить");
            formDep.Index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            formDep.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Departments.ToList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons box = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "", box);

            if (result == DialogResult.No)
                return;

            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    int? currentId = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value);
                    Department d = ListsComponent.GetObjById<Department>(currentId);
                    ListsComponent.Delete(d);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(@"Данные, которую вы хотите удалить используется приложением. 
Пожалуйста, удалите сначала эти данные с других списков)))");
            }

            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Departments.ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Departments.Where(d=>d.Name.Contains(textBox1.Text)).ToList();
            }
        }
    }
}
