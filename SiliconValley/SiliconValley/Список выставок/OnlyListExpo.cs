using SiliconValley.Список_картин;
using SiliconValley.Список_отделов;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_выставок
{
    public partial class OnlyListExpo : Form
    {
        public string ExpoHeader { get; } = "Выберите выставку";
        public string DepartmentHeader { get; } = "Выберите отдел";

        Send_picture send_Picture;
        public OnlyListExpo()
        {
            InitializeComponent();

            this.send_Picture = send_Picture;
        }

        private void OnlyListExpo_Load(object sender, EventArgs e)
        {
        }

        public void ExpoInit()
        {
            Text = ExpoHeader;

            Context db = new Context();

            GridExpo.DataSource = db.Expos.ToList();

            button1.Text = "Добавить выставку";

            GridExpo.CellDoubleClick += DoubleClickRow_Expo;
        }

        public void PlacementInit()
        {
            Text = DepartmentHeader;
            
            Context db = new Context();
           
            GridExpo.DataSource = db.Departments.ToList();

            button1.Text = "Добавить отдел";

            GridExpo.CellDoubleClick += DoubleClickRow_Placement;
        }

        void DoubleClickRow_Expo(object sender, DataGridViewCellEventArgs e)
        {
            Send_picture.placementId = Convert.ToInt32(GridExpo.CurrentRow.Cells[3].Value);
            Close();
        }


        void DoubleClickRow_Placement(object sender, DataGridViewCellEventArgs e)
        {
            Send_picture.placementId = Convert.ToInt32(GridExpo.CurrentRow.Cells[0].Value);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Text == ExpoHeader)
            {
                Form_expos form_Expos = new Form_expos("Добавить выставку", "Добавить");
                form_Expos.ShowDialog();

                var db = new Context();
                GridExpo.DataSource = db.Expos.ToList();
            }

            if (Text == DepartmentHeader)
            {
                Form_department form_Department = new Form_department("Добавить отдел", "Добавить");
                form_Department.ShowDialog();

                var db = new Context();
                GridExpo.DataSource = db.Departments.ToList();
            }
        }
    }
}
