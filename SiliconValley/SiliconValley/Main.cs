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
using SiliconValley.Список_Жанров;
using SiliconValley.Авторизация;
using SiliconValley.Список_сотрдников;
using SiliconValley.Список_выставок;
using SiliconValley.Список_отделов;


namespace SiliconValley
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckAccess();
        }
        private void списокАвторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_artists l_artists = new List_artists {
                MdiParent = this
            };
            l_artists.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            l_artists.Show();
        }

        private void списокКартинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_pictures l_pictures = new List_pictures {
                MdiParent = this
            };
            l_pictures.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            l_pictures.Show();
        }

        private void listGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_genres listGenres = new List_genres() {
                MdiParent = this
            };
            listGenres.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            listGenres.Show();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_employees listEmployees = new List_employees() {
                MdiParent = this
            };
            listEmployees.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            listEmployees.Show();
        }

        void CheckAccess()
        {
            if (Position.Admin == Auth.User?.Position) {
                listEmployeeToolStripMenuItem.Visible = true;
            }
        }

        private void списокВыставокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List_expos listExpos = new List_expos() {
                MdiParent = this
            };
            listExpos.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            listExpos.Show();
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void списокВыставокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_departments listDeps = new List_departments()
            {
                MdiParent = this
            };
            listDeps.LayoutMdi(MdiLayout.Cascade);
            if (Application.OpenForms["list"] != null)
                ActiveMdiChild.Close();
            listDeps.Show();
        }
    }
}
