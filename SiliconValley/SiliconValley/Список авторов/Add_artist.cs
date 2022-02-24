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
    public partial class Add_artist : Form
    {
        public Add_artist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                var art1 = new Artist { Name = textBox1.Text, Birthday = dateTimePicker1.Value };
                db.Artists.Add(art1);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
