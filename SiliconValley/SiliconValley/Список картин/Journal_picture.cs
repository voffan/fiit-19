using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            Picture journal = ListsComponent.GetObjById<Picture>(pictureId);

            this.placementId = journal.PlacementId;

            Text = "История картины " + journal.Name;
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
            Context c = new Context();

            var list = from move in c.Journals
                       join emp in c.Employees
                       on move.EmployeeId equals emp.Id
                       where move.PictureId == pictureId
                       select new
                       {
                           Из = ListsComponent.GetObjById<Placement>(move.FromID).Name,
                           В = ListsComponent.GetObjById<Placement>(move.ToID).Name,
                           Дата = move.Date,
                           Логин = emp.Login
                        }
                        ;

            /*foreach (var item in list)
            {
                int fromId = item.FromID;
                int toId = item.ToID;

                Placement placeFrom = ListsComponent.GetObjById<Placement>(fromId);
                Placement placeTo = ListsComponent.GetObjById<Placement>(toId);

                string currentItem = placeFrom.Name + " -> " + placeTo.Name;
                listBox1.Items.Add(currentItem);
            }*/

            dataGridView1.DataSource = list.ToList();
        }

        
    }
}
