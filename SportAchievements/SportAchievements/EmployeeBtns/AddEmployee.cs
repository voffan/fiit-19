using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportAchievements.Components;

namespace SportAchievements
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            pos.DataSource = new BindingSource(Classes.DescriptionAttributes<Classes.Position>.RetrieveAttributes(), null);
            pos.DisplayMember = "Key";
            pos.ValueMember = "Value";
        }

        private void addEmpl_Click(object sender, EventArgs e)
        {
            if (lgn.Text.Length > 0 && psw.Text.Length > 0 && FIO.Text.Length > 0 && bdate.Value.Date.ToString().Length > 0 && pos.Text.Length > 0)
            {
                try
                {
                    EmployeeComp.AddEmployee(Authorization.con, lgn.Text, psw.Text, FIO.Text, bdate.Value.Date, (Classes.Position)Enum.Parse(typeof(Classes.Position), (string)pos.SelectedValue));
                    Close();
                }
                catch
                {

                }
            }
            else MessageBox.Show("Заполните все поля!");
        }
    }
}
