using SiliconValley.Список_картин;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_выставок
{
    public partial class OnlyListExpo : Form
    {
        public string ExpoHeader { get; } = "Выберите выставку";
        public string PlacementHeader { get; } = "Выберите отдел";

        public OnlyListExpo()
        {
            InitializeComponent();
        }

        private void OnlyListExpo_Load(object sender, EventArgs e)
        {
        }

        public void ExpoInit()
        {
            Text = ExpoHeader;

            Context db = new Context();

            GridExpo.DataSource = db.Expos.ToList();

            GridExpo.CellDoubleClick += DoubleClickRow_Expo;
        }

        public void PlacementInit()
        {
            Text = PlacementHeader;
            
            Context db = new Context();
           
            GridExpo.DataSource = db.Placements.ToList();

            GridExpo.CellDoubleClick += DoubleClickRow_Placement;
        }

        void DoubleClickRow_Expo(object sender, DataGridViewCellEventArgs e)
        {
            Send_picture.placementId = Convert.ToInt32(GridExpo.CurrentRow.Cells[3].Value);
            Close();
        }


        void DoubleClickRow_Placement(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
            Close();
        }
    }
}
