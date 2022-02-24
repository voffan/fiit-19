using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_картин
{
    public partial class List_pictures : Form
    {
        public List_pictures()
        {
            InitializeComponent();
            this.Name = "list";
        }

        private void List_pictures_Load(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                var pictures = db.Pictures.ToList();
                dataGridView1.DataSource = pictures;
            }
        }
    }
}
