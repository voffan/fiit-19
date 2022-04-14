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
using SportAchievements.Classes;

namespace SportAchievements.EmployeeBtns
{
    public partial class EditEmpl : Form
    {
        int Id;
        Employee empl;

        public EditEmpl(int Id)
        {
            this.Id = Id;
            InitializeComponent();
            empl = (new Context()).Employees.Find(Id);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (lgn.Text.Length > 0 && psw.Text.Length > 0 && FIO.Text.Length > 0 && bdate.Value.Date.ToString().Length > 0 && pos.Text.Length > 0)
            {
                try
                {

                    EmployeeComp.ChEmpl(Authorization.con, lgn.Text, psw.Text, FIO.Text, bdate.Value.Date, (Classes.Position)Enum.Parse(typeof(Classes.Position), (string)pos.SelectedValue), Id);
                    Close();
                }
                catch
                {

                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void EditEmpl_Load(object sender, EventArgs e)
        {
            if (empl == null)
            {
                MessageBox.Show("Сотрудник не найден!");
                Close();
            }
            lgn.Text = empl.Login;
            psw.Text = empl.Pwd;
            FIO.Text = empl.Name;
            bdate.Value = empl.BirthDate;
            pos.DataSource = new BindingSource(Classes.DescriptionAttributes<Classes.Position>.RetrieveAttributes(), null);
            pos.DisplayMember = "Key";
            pos.ValueMember = "Value";
            var obj = (from KeyValuePair<string, string> s in pos.Items where s.Value == Enum.GetName(typeof(SportAchievements.Classes.Position), empl.Position) select s).FirstOrDefault();
            pos.SelectedItem = obj;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
