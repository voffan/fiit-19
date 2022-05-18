using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

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
            Send_picture sendForm = new Send_picture(pictureId, placementId);

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
                           Соторудник = emp.Surname + " "+ emp.Name +" "+ emp.Patronymic
                        };

            dataGridView1.DataSource = list.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = CreateWordReport();

            if (filename == null)
                return;

            Microsoft.Office.Interop.Word.Application application = null;
            application = new Microsoft.Office.Interop.Word.Application();
            var document = application.Documents.Add();

            Table table = SettingsTable(application,document);

            CreateTableForWord(table);

            try
            {
                application.ActiveDocument.SaveAs(filename, WdSaveFormat.wdFormatDocumentDefault);//try
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            document.Close();

            MessageBox.Show("Отчет создан");
        }


        string CreateWordReport()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word File |*.docx;";
            saveFileDialog.Title = "Сохранить отчет";
            saveFileDialog.FileName = $"{Text}.docx";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return null;
            


            return saveFileDialog.FileName;
        }

        Table SettingsTable(Microsoft.Office.Interop.Word.Application application, Document document)
        {
            var paragraph = document.Paragraphs.Add();
            paragraph.Range.Font.Size = 20;
            paragraph.Range.Bold = 1;
            paragraph.Range.Text = $"{Text}\n";

            Range tableLocation = document.Range(paragraph.Range.Start);
            document.Tables.Add(tableLocation, dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count);

            document.Tables[1].Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            document.Tables[1].Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

            document.Tables[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            return document.Tables[1];
        }
        void CreateTableForWord(Table table)
        {
            for (int j = 0; j < dataGridView1.Columns.Count; j++)//Создание заголовка
            {
                table.Cell(1, j + 1).Range.Font.Bold = 1;
                table.Cell(1, j + 1).Range.Font.Size = 16;

                table.Cell(1, j + 1).Range.Text = dataGridView1.Columns[j].Name;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)//Создание таблицы
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Font.Size = 12;
                    table.Cell(i + 2, j + 1).Range.Font.Bold = 0;
                    table.Cell(i+2,j+1).Range.Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}

