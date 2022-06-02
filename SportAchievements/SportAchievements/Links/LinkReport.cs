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


                int i = 6;

                foreach (Result res in results)
                {
                    if (!new_sportsmen.Contains(res.Sportsman.Name))
                    {
                        new_sportsmen.Add(res.Sportsman.Name);

                    }
                }

                sheet.get_Range("D5", "G5").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range("D5", "G5").Font.Bold = true;
                sheet.get_Range("D5", "G5").Font.Size = 13;
                sheet.get_Range("D5", "G5").ColumnWidth = 20;
                //sheet.get_Range("D5", "G5").Interior.Color = Excel.XlRgbColor.rgbBlueViolet;
                //sheet.get_Range("D6", "G99999").Interior.Color = Excel.XlRgbColor.rgbDarkCyan;

                string fullName = "ФИО";
                string gender = "Пол";
                string weightCategory = "Весовая категория";
                string amount = "Количество";

                sheet.Cells[5, 4] = fullName;
                sheet.Cells[5, 5] = gender;
                sheet.Cells[5, 6] = weightCategory;
                sheet.Cells[5, 7] = amount;
                sheet.Cells[3, 4] = "Спортсмены с наибольшим количеством призовых мест по виду спорта \"" + sport + "\"";

                sheet.Cells[3, 4].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[3, 4].Font.Bold = true;
                sheet.Cells[3, 4].Font.Size = 15;
                sheet.Cells[3, 4].ColumnWidth = 50;
                sheet.Cells[3, 4].RowHeight = 25;

                sheet.get_Range("D3", "G3").Merge();

                /*sheet.Cells[5, 4].Characters[0, fullName.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                sheet.Cells[5, 5].Characters[0, gender.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                sheet.Cells[5, 6].Characters[0, weightCategory.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                sheet.Cells[5, 7].Characters[0, amount.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);*/

                /*foreach (string s in new_sportsmen)
                {
                    sheet.Cells[i, 4].ColumnWidth = s.Max();
                }*/

                foreach (string s in new_sportsmen)
                {
                    sheet.Cells[i, 4] = s;
                    sheet.Cells[i, 4].Characters[0, s.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGray);
                    if ((from st in sportsmen
                         where st.Name == s
                         select st.Gender.ToString()).FirstOrDefault() == "Man")
                    {
                        sheet.Cells[i, 5] = "Мужской";
                        sheet.Cells[i, 5].Characters[0, 7].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGray);
                    }
                    else
                    {
                        sheet.Cells[i, 5] = "Женский";
                        sheet.Cells[i, 5].Characters[0, 7].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGray);
                    }
                    //Dictionary<string, string> Gender = DescriptionAttributes<Gender>.RetrieveAttributes();

                    sheet.Cells[i, 6] = (from r in results
                                         join w in wc on r.WeightCategoryId equals w.Id
                                         where r.Sportsman.Name == s
                                         select w.Name).FirstOrDefault();

                    sheet.Cells[i, 6].Characters[0, 7].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGray);

                    sheet.Cells[i, 7] = (from st in results
                                         where st.Place < 4
                                         && st.Sportsman.Name == s
                                         select st).Count();

                    sheet.Cells[i, 7].Characters[0, (from st in results
                                                     where st.Place < 4
                                                     && st.Sportsman.Name == s
                                                     select st).Count()].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGray);
                    i++;
                }

            }

            if (Report2.Checked == true)
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
                int[] nums = new int[col + 1];

                //////////////////////////////////////////////////////////////////////////////////////

                int i = 1;

                sheet.get_Range("D5", "H5").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range("D5", "H5").Font.Bold = true;
                sheet.get_Range("D5", "H5").Font.Size = 13;
                sheet.get_Range("D5", "H5").ColumnWidth = 20;
                sheet.get_Range("D5", "H5").Interior.Color = Excel.XlRgbColor.rgbBlueViolet;
                sheet.get_Range("D6", "H99999").Interior.Color = Excel.XlRgbColor.rgbLightBlue;

                string fullNameText = "ФИО";
                string kindOfCompetitionText = "Вид соревнования";
                string placeText = "Место";
                string pointsText = "Очки";
                string weightCategoryText = "Весовая категория";


                sheet.Cells[5, 4] = fullNameText;
                sheet.Cells[5, 5] = kindOfCompetitionText;
                sheet.Cells[5, 6] = placeText;
                sheet.Cells[5, 7] = pointsText;
                sheet.Cells[5, 8] = weightCategoryText;
                sheet.Cells[3, 4] = "Победители по виду спорта \"" + sport + "\" за заданный период времени";

                sheet.Cells[3, 4].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[3, 4].Font.Bold = true;
                sheet.Cells[3, 4].Font.Size = 15;
                sheet.Cells[3, 4].ColumnWidth = 50;
                sheet.Cells[3, 4].RowHeight = 25;

                sheet.get_Range("D3", "H3").Merge();

                sheet.Cells[5, 4].Characters[0, fullNameText.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                sheet.Cells[5, 5].Characters[0, kindOfCompetitionText.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                sheet.Cells[5, 6].Characters[0, placeText.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                sheet.Cells[5, 7].Characters[0, pointsText.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                sheet.Cells[5, 8].Characters[0, weightCategoryText.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

                /*foreach (string s in new_sportsmen)
                {
                    sheet.Cells[i, 4].ColumnWidth = s.Max();
                }*/

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
                        sheet.Cells[j, 4] = h;
                        sheet.Cells[i, 4].Characters[0, h.Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

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
                        sheet.Cells[i, 3].Characters[0, h.ToString().Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

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
                        sheet.Cells[i, 5].Characters[0, wc.ToString().Length].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

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
