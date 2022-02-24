using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiliconValley.Список_картин;
using SiliconValley.Список_авторов;

namespace SiliconValley
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void списокАвторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_artists l_artists = new List_artists
            {
                MdiParent = this
            };
            l_artists.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            l_artists.Show();

        }

        private void списокКартинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_pictures l_pictures = new List_pictures
            {
                MdiParent = this
            };
            l_pictures.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            l_pictures.Show();
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
