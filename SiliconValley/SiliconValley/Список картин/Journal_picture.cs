using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Aspose.Words;

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
            CreateWordReport();
        }


        void CreateWordReport()
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word File |*.docx;";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.FileName = $"{Text}.docx";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Document doc = new Document();
            doc.Watermark.Remove();
            DocumentBuilder builder = new DocumentBuilder(doc);


            Font font = builder.Font;
            font.Size = 16;
            font.Bold = true;
            font.Color = System.Drawing.Color.Black;
            font.Name = "Times new roman";

            // Insert text
            builder.Writeln($"{Text}.\n");

            CreateTableForWord(builder,font);

            try
            {
                doc.Save($"{saveFileDialog1.FileName}");
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            MessageBox.Show("Отчет создан");
        }

        void CreateTableForWord(DocumentBuilder builder, Font font)
        {
            builder.StartTable();

            for (int j = 0; j < dataGridView1.Columns.Count; j++)//Создание заголовка
            {
                builder.InsertCell();
                builder.Write(dataGridView1.Columns[j].Name);
            }
            builder.EndRow();

            font.Size = 12;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)//Создание таблицы
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    builder.InsertCell();
                    builder.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                builder.EndRow();
            }
            builder.EndTable();
        }
    }
}

