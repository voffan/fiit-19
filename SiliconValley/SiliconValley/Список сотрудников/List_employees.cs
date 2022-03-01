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
        SqlConnection sqlConnection;
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
        private void AddGenre_Click(object sender, EventArgs e)
        {

        } 
    }
}
