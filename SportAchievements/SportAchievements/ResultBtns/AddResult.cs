using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportAchievements.ResultBtns
{
    public partial class AddResult : Form
    {
        public AddResult()
        {
            InitializeComponent();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            competition.Visible = false;
        }
    }
}
