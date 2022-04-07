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
    public partial class Journal_picture : Form
    {
        int pictureId;
        int placementId;
        public Journal_picture(int id,int placementId)
        {
            InitializeComponent();

            this.pictureId = id;
            this.placementId = placementId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send_picture sendForm = new Send_picture(pictureId,placementId);

            sendForm.ShowDialog();
        }
    }
}
