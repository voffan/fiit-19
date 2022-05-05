using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Статистика
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            Context context = new Context();

            var expoPictures = from picture in context.Pictures.Include("Placement").Include("Genre").Include("Artist")
                               join expo in context.Expos
                               on picture.PlacementId equals expo.Id
                               select picture;

            dataGridView1.DataSource = expoPictures.ToList();

            var count = from picture in context.Pictures
                        join department in context.Departments
                        on picture.PlacementId equals department.Id
                        where department.Name == "Реставрация"
                        select picture;

            label3.Text = count.ToList().Count.ToString();
            label2.Location = new Point() { Y = this.Size.Height - 100, X = 40 };
            label3.Location = new Point() { Y = label2.Location.Y, X = label2.Location.X + label2.Width+20 };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
