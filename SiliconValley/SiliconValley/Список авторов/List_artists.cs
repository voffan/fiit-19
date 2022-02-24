using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_авторов
{
    public partial class List_artists : Form
    {
        public List_artists()
        {
            InitializeComponent();
            this.Name = "list";
        }

        private void List_artists_Load(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Artists.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_artist add_artist = new Add_artist();
            add_artist.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Artists.ToList();
            /*using (var db = new Context())
            {
                var artists = new List<Artist>
                {
                    new Artist { Name = "Пабло Пикассо", Birthday = DateTime.Parse("1881-10-25")},
                    new Artist { Name = "Клод Моне", Birthday = DateTime.Parse("1840-11-14")},
                    new Artist { Name = "Сальвадор Дали", Birthday = DateTime.Parse("1904-5-11")},
                    new Artist { Name = "Винсент Ван Гог", Birthday = DateTime.Parse("1853-3-30")},
                    new Artist { Name = "Пьер Огюст Ренуар", Birthday = DateTime.Parse("1841-2-25")}
                };
                db.Artists.AddRange(artists);
                db.SaveChanges();
                dataGridView1.DataSource = db.Artists.ToList();
            }*/
        }
    }
}
