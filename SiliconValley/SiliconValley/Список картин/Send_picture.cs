using SiliconValley.Авторизация;
using SiliconValley.Список_выставок;
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
    public partial class Send_picture : Form
    {
        int pictureId;
        int FromId;
        public static int placementId=-1;//выбранный placement
        public Send_picture(int id,int placementId)
        {
            InitializeComponent();
            pictureId = id;
            FromId = placementId;
        }

        //выбор выставки
        private void button1_Click(object sender, EventArgs e)
        {
            OnlyListExpo listExpo = new OnlyListExpo();

            listExpo.ExpoInit();

            listExpo.ShowDialog();

            ActiveName();
        }

        //выбор отдела
        private void button2_Click(object sender, EventArgs e)
        {
            OnlyListExpo listPlacement = new OnlyListExpo();

            listPlacement.PlacementInit();

            listPlacement.ShowDialog();

            ActiveName();
        }

        //Отправить
        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Visible == true)
            {
                MessageBox.Show("Выберите куда отправить");
                return;
            }

            AddJournal();

            ChangeCurrentPlacementPicture();

            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            button4.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
        }

        void ActiveName()//После выбора отображает выбранную местность
        {
            if (placementId != -1)
            {
                label3.Visible = true;
                button4.Visible = true;

                Placement placement = ListsComponent.GetObjById<Placement>(placementId);
                label3.Text = placement.Name;

                button1.Visible = false;
                button2.Visible = false;
            }
        }

        void AddJournal()//добавляет в таблицу Journal движение одной картины
        {
            Journal journal = new Journal();

            journal.Date = dateTimePicker1.Value;
            journal.PictureId = pictureId;
            journal.FromID = FromId;
            journal.ToID = placementId;
            journal.EmployeeId = Auth.User.Id;

            ListsComponent.Add(journal);
        }

        void ChangeCurrentPlacementPicture()//изменить текущий placement картины
        {
            Picture picture = ListsComponent.GetObjById<Picture>(pictureId);

            picture.PlacementId = placementId;

            ListsComponent.Edit(picture);
        }
    }
}