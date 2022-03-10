using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportAchievements
{
    public partial class LinkEmployee : Form
    {
        public LinkEmployee()
        {
            InitializeComponent();
        }

        private void LinkEmployee_Load(object sender, EventArgs e)
        {
            InitTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee Employee = new AddEmployee();
            Employee.ShowDialog();
            InitTable();
        }

        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Employees.ToList();
            /*dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;*/
            dataGridView1.Columns[4].HeaderText = "Имя";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";
            //dataGridView1.Columns[0].Visible = false;    ВИЖОН
            //dataGridView1.Columns[1].HeaderText = "";    МОЖНО МЕНЯТЬ НАЗВАНИЕ ВАУ!
        }
    }
}
