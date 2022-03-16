using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCo
{
    public partial class Form_Motherboards : Form
    {
        public static Context context = new Context();
        public Form_Motherboards()
        {
            InitializeComponent();
        }

        private void Motherboards_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Motherboards.ToList();
            //            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Производитель";
            /*            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            for (int _i = 0; _i < dataGridView1.RowCount; _i++)
                            {
                                dataGridView1.Rows.Add();
                            }
                        }*/
        }
    }
}
