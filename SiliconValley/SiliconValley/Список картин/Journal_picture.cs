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
        int pictureId;//id выбранной картины
        int placementId;
        public Journal_picture(int id)
        {
            InitializeComponent();

            this.pictureId = id;
            this.placementId = ListsComponent.GetObjById<Picture>(pictureId).PlacementId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send_picture sendForm = new Send_picture(pictureId,placementId);

            sendForm.ShowDialog();

            ShowHistoryMovement();

            placementId = ListsComponent.GetObjById<Picture>(pictureId).PlacementId;
        }

        private void Journal_picture_Load(object sender, EventArgs e)
        {
            ShowHistoryMovement();
        }


        void ShowHistoryMovement()
        {
            listBox1.Items.Clear();

            Context c = new Context();

            var list = from obj in c.Journals
                        where obj.PictureId == pictureId
                        select new
                        {
                            fromId = obj.FromID,
                            toId = obj.ToID
                        }
                        ;

            foreach (var item in list)
            {
                int fromId = item.fromId;
                int toId = item.toId;

                Placement placeFrom = ListsComponent.GetObjById<Placement>(fromId);
                Placement placeTo = ListsComponent.GetObjById<Placement>(toId);

                string currentItem = placeFrom.Name + " -> " + placeTo.Name;
                listBox1.Items.Add(currentItem);
            }

            
        }

    }
}
