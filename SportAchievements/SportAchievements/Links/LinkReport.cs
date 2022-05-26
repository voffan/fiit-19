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
            //ex.Visible = true;
            ex.SheetsInNewWorkbook = 1;
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);

            if (Report1.Checked == true)
            {
                sheet.Name = "Отчет " + DateTime.Parse(DateTime.Now.Date.ToString()).ToShortDateString();
                


                string sport = sportKind.Text;

                List<Result> results = c.Results.Where(r => r.Sport.Name.ToString().Contains(sport)).ToList();
                List<Sportsman> sportsmen = c.Sportsmen.ToList();
                List<string> new_sportsmen = new List<string>();
                List<WeightCategory> wc = c.WeightCategories.ToList();


                int i = 2;

                foreach (Result res in results)
                {
                    if (!new_sportsmen.Contains(res.Sportsman.Name))
                    {
                        new_sportsmen.Add(res.Sportsman.Name);
                       
                    }
                }

                sheet.get_Range("A1", "D1").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range("A1", "D1").Font.Bold = true;
                sheet.get_Range("A1", "D1").Font.Size = 13;
                sheet.get_Range("A1", "D1").ColumnWidth = 20;
                sheet.Cells[1, 1] = "ФИО";
                sheet.Cells[1, 2] = "Пол";
                sheet.Cells[1, 3] = "Весовая категория";
                sheet.Cells[1, 4] = "Количество";

                foreach (string s in new_sportsmen)
                {
                    sheet.Cells[i, 1] = s;
                    if ((from st in sportsmen
                         where st.Name == s
                         select st.Gender.ToString()).FirstOrDefault() == "Man")
                    {
                        sheet.Cells[i, 2] = "Мужской";
                    }
                    else
                    {
                        sheet.Cells[i, 2] = "Женский";
                    }
                    //Dictionary<string, string> Gender = DescriptionAttributes<Gender>.RetrieveAttributes();
                    
                    sheet.Cells[i, 3] = (from r in results
                                         join w in wc on r.WeightCategoryId equals w.Id
                                         where r.Sportsman.Name == s
                                         select w.Name).FirstOrDefault();
                    sheet.Cells[i, 4] = (from st in results
                                         where st.Place < 4
                                         && st.Sportsman.Name == s
                                         select st).Count();
                    i++;
                }

            }

            if (Report2.Checked ==  true)
            {
                sheet.Name = "Отчет " + DateTime.Parse(DateTime.Now.Date.ToString()).ToShortDateString();
                
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker2.Value;

                
                string sport = sportKind.Text;

                List<Result> results = c.Results.Where(r => r.Sport.Name.ToString().Contains(sport)).ToList();

                
                List<DateTime> new_com_1 = new List<DateTime>();
                List<DateTime> new_com_2 = new List<DateTime>();
                List<string> com = new List<string>();
                List<int> place = new List<int>();
                List<int> point = new List<int>();
                List<string> new_sportsmen = new List<string>();
                List<WeightCategory> weightCategories = c.WeightCategories.ToList();
                //List<string> categ = new List<string>();
                List<string> vit = new List<string>();

                List<Sportsman> sportsmen = c.Sportsmen.ToList();
                


                foreach (Result res in results)
                {
                    new_com_1.Add(res.Competition.DateBeginning);
                    new_com_2.Add(res.Competition.DateEnding);
                    com.Add(res.Competition.Name);
                    //categ.Add(res.WeightCategory.Name.ToString());
                    place.Add(res.Place);
                    point.Add(res.Points);
                    new_sportsmen.Add(res.Sportsman.Name);
                }

                int col = new_com_2.Count();
                int[] nums = new int[col+1];

                //////////////////////////////////////////////////////////////////////////////////////

                int i = 1;

                sheet.get_Range("A1", "E1").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range("A1", "E1").Font.Bold = true;
                sheet.get_Range("A1", "E1").Font.Size = 13;
                sheet.get_Range("A1", "E1").ColumnWidth = 20;
                sheet.Cells[1, 1] = "ФИО";
                sheet.Cells[1, 2] = "Вид соревнования";
                sheet.Cells[1, 3] = "Место";
                sheet.Cells[1, 4] = "Очки";
                sheet.Cells[1, 5] = "Весовая категория";

                foreach (DateTime s in new_com_2)
                {

                    if ((s > start) && (s < end))
                    {
                        //sheet.Cells[i, 1] = s;

                        nums[i] = 1;
                        i++;
                    }
                    else 
                    {
                        nums[i] = 0;
                        i++;
                    }

                    
                }
                i = 1;
                foreach (int h in place)
                {
                    if (h >= 4)
                    {
                        nums[i] = 0;
                        i++;
                    }
                    else 
                    {
                        i++;
                    }
                    
                    
                }
          
                i = 1;
                int j = 2;
                foreach (string h in new_sportsmen)
                {
                    if (nums[i] == 1)
                    {
                        sheet.Cells[j, 1] = h;


                        i++;
                        j++;
                    }
                    else 
                    {
                        i++;
                    }
                }
                i = 1;
                j = 2;
                foreach (string h in com)
                {
                    if (nums[i] == 1)
                    {
                        sheet.Cells[j, 2] = h;


                        i++;
                        j++;
                    }
                    else 
                    {
                        i++;
                    }
                }
                i = 1;
                j = 2;
                foreach (int h in place)
                {
                    if (nums[i] == 1)
                    {
                        sheet.Cells[j, 3] = h.ToString();


                        i++;
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                }
                i = 1;
                j = 2;
                foreach (int h in point)
                {
                    if (nums[i] == 1)
                    {
                        sheet.Cells[j, 4] = h.ToString();


                        i++;
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                }
                i = 1;
                j = 2;
                foreach (WeightCategory wc in weightCategories)
                {
                    if (nums[i] == 1)
                    {
                        sheet.Cells[j, 5] = wc.ToString();


                        i++;
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                }

            }

            DialogResult result = MessageBox.Show("Отчет сформирован. \nНажмите 'Да', чтобы открыь отчет. \nНажмите 'Нет', чтобы сохранить файл.", "Экспорт в Excel", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            { ex.Visible = true; }
            if (result == DialogResult.No)
            {
                string fileName = String.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                }
                else
                    return;
                //сохраняем Workbook
                workBook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                saveFileDialog1.Dispose();
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Сохранение результатов экспорта отменено");
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
