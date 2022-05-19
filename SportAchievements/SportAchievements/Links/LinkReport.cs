using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportAchievements.Components;
using SportAchievements.Classes;
using SportAchievements.ReportBtns;
using Excel = Microsoft.Office.Interop.Excel;

namespace SportAchievements
{
    public partial class LinkReport : Form
    {
        public LinkReport()
        {
            InitializeComponent();
        }

        private void LinkReport_Load(object sender, EventArgs e)
        {

            InitTable();
            using (Context c = new Context())
            {
                sportKind.DataSource = c.KindsOfSports.ToList();
                sportKind.DisplayMember = "Name";
                sportKind.ValueMember = "Id";
            }
            sportKind.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Results.Include("WeightCategory").ToList();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddReport Report = new AddReport();
            Report.ShowDialog();
            InitTable();
        }

        private void Report1_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            Excel.Application ex = new Excel.Application();
            ex.Visible = true;
            ex.SheetsInNewWorkbook = 1;
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
      
            if (Report1.Checked == true)
            {
                sheet.Name = "Отчет " + DateTime.Parse(DateTime.Now.Date.ToString()).ToShortDateString();
                string sport = sportKind.Text;
                
                List<Sportsman> sportsmen = c.Sportsmen.ToList();
                string[][] new_sportsmen = new string[sportsmen.Count][];
                List<Result> results = c.Results.ToList();

                int i = 0;
                foreach (Result res in results)
                {
                    
                    if (res.Sport.Name == sport)
                    {
                        Sportsman sportsman = (from Sportsman s in results where s.Id == res.SportsmanId select s).FirstOrDefault();
                        for (int j = 0; j < 4; j++)
                            new_sportsmen[i][j] = res.Sportsman.Name;
                        
                    }
                    i++;
                }
            }

            if (Report2.Checked ==  true)
            {
                sheet.Name = "Отчет " + DateTime.Parse(DateTime.Now.Date.ToString()).ToShortDateString();
                string sport = sportKind.Text;
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker1.Value;

            }
        }

        private void Report1_CheckedChanged(object sender, EventArgs e)
        {
            if (Report1.Checked == true)
            {
                label1.Visible = true;
                sportKind.Visible = true;
            }
        }

        private void Report2_CheckedChanged(object sender, EventArgs e)
        {
            if (Report2.Checked == true)
            {
                label1.Visible = true;
                sportKind.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }
    }
}
