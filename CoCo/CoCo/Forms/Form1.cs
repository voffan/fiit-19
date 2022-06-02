using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoCo.Classes;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace CoCo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Form_Pcs form_pcs;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Компьютеры")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_pcs = new Form_Pcs();
                form_pcs.Text = "Компьютеры";
                form_pcs.MdiParent = this;
                form_pcs.Show();
            }
        }

        private void компьютерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            Show_Child_Form(new Form_Pcs());
            Form_Pcs form_pcs;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Компьютеры")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_pcs = new Form_Pcs();
                form_pcs.Text = "Компьютеры";
                form_pcs.MdiParent = this;
                form_pcs.Show();
            }
        }

        private void периферияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //           Show_Child_Form(new Form_Peripherals());
            Form_Peripherals form_per;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Периферия")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_per = new Form_Peripherals();
                form_per.Text = "Периферия";
                form_per.MdiParent = this;
                form_per.Show();
            }
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //           Show_Child_Form(new Form_Employees());
            Form_Employees form_per;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Сотрудники")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_per = new Form_Employees();
                form_per.Text = "Сотрудники";
                form_per.MdiParent = this;
                form_per.Show();
            }
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            Show_Child_Form(new Form_Departments());
            Form_Departments form_per;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Отделы")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_per = new Form_Departments();
                form_per.Text = "Отделы";
                form_per.MdiParent = this;
                form_per.Show();
            }
        }

        private void матПлатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            Show_Child_Form(new Form_Motherboards());
            Form_Motherboards form_per;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Материнские платы")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_per = new Form_Motherboards();
                form_per.Text = "Материнские платы";
                form_per.MdiParent = this;
                form_per.Show();
            }
        }

        private void жДискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show_Child_Form(new Form_Hdds());
            Form_Hdds form_Hdds;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Жесткие диски")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_Hdds = new Form_Hdds();
                form_Hdds.Text = "Жесткие диски";
                form_Hdds.MdiParent = this;
                form_Hdds.Show();
            }
        }

        private void процессорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            Show_Child_Form(new Form_Cpus());
            Form_Cpus form_Hdds;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Процессоры")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_Hdds = new Form_Cpus();
                form_Hdds.Text = "Процессоры";
                form_Hdds.MdiParent = this;
                form_Hdds.Show();
            }
        }

        private void ремонтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            Show_Child_Form(new Form_Repairs());
            Form_Repairs form_Hdds;
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Ремонты")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_Hdds = new Form_Repairs();
                form_Hdds.Text = "Ремонты";
                form_Hdds.MdiParent = this;
                form_Hdds.Show();
            }
        }
        private void Show_Child_Form(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context context = new Context();
        }

        



        private void оРаботающихКомпьютерахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using(var excel = new ReportLogic())
                {
                    if (excel.Open(filePath: Path.Combine(Environment.CurrentDirectory, $"Отчет о работающих компьютерах за {DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} {DateTime.Now.Hour}ч{DateTime.Now.Minute}м.xlsx")))
                    {
                        
                        Context context = new Context();
                        List<PC> pcs = (from PC d in context.PCs
                                        where d.Status == Status.working
                                        select d).ToList();
                        excel.Set("A", 1, "Сотрудник");
                        excel.Set("B", 1, "Процессор");
                        excel.Set("E", 1, "Жесткий диск");
                        excel.Set("H", 1, "Материнская плата");
                        excel.Set("J", 1, "Инвентарный номер");
                        for (int i = 0; i < pcs.Count; i++)
                        {
                            excel.Set("A", i+2, pcs[i].Employee.FullName);

                            excel.Set("B", i+2, pcs[i].Cpu.Name);
                            excel.Set("C", i+2, pcs[i].Cpu.Frequency);
                            excel.Set("D", i+2, pcs[i].Cpu.Manufacturer);

                            excel.Set("E", i + 2, pcs[i].Hdd.Name);
                            excel.Set("F", i + 2, pcs[i].Hdd.Volume);
                            excel.Set("G", i + 2, pcs[i].Hdd.Manufacturer);

                            excel.Set("H",i+2, pcs[i].Motherboard.Name);
                            excel.Set("I", i + 2, pcs[i].Motherboard.Manufacturer);

                            excel.Set("J",i+2,pcs[i].InventoryNumber);
                        }
                      
                        excel.Save();
                    }
                    MessageBox.Show("Успешно сохранено");
                }
            }catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Call to developer");
            }
           

            //Excel.SpreadSheet ex = new Excel.Application();
            //ex.SheetsInNewWorkbook = 1;
            //Workbook workBook = ex.Workbooks.Add(Type.Missing);
            //ex.DisplayAlerts = false;
            //Excel.SpreadSheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            //sheet.Name = "Отчет о работающих компьютерах от " + DateTime.Today.ToString();
            //Context context = new Context();
            //List<PC> pcs = (from PC d in context.PCs
            //                where d.Status == Status.working
            //                select d).ToList();
            //for (int i = 0; i < pcs.Count; i++)
            //{
            //    sheet.Cells[i, 1] = pcs[i].Id;
            //}
            //context.Dispose();
        }

        private void оСписанныхКомпьютерахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var excel = new ReportLogic())
                {
                    if (excel.Open(filePath: Path.Combine(Environment.CurrentDirectory, $"Отчет о списанных компьютерах за {DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} {DateTime.Now.Hour}ч{DateTime.Now.Minute}м.xlsx")))
                    {

                        Context context = new Context();
                        List<PC> pcs = (from PC d in context.PCs
                                        where d.Status == Status.writtenoff
                                        select d).ToList();
                        excel.Set("A", 1, "Сотрудник");
                        excel.Set("B", 1, "Процессор");
                        excel.Set("E", 1, "Жесткий диск");
                        excel.Set("H", 1, "Материнская плата");
                        excel.Set("J", 1, "Инвентарный номер");
                        for (int i = 0; i < pcs.Count; i++)
                        {
                            excel.Set("A", i + 2, pcs[i].Employee.FullName);

                            excel.Set("B", i + 2, pcs[i].Cpu.Name);
                            excel.Set("C", i + 2, pcs[i].Cpu.Frequency);
                            excel.Set("D", i + 2, pcs[i].Cpu.Manufacturer);

                            excel.Set("E", i + 2, pcs[i].Hdd.Name);
                            excel.Set("F", i + 2, pcs[i].Hdd.Volume);
                            excel.Set("G", i + 2, pcs[i].Hdd.Manufacturer);

                            excel.Set("H", i + 2, pcs[i].Motherboard.Name);
                            excel.Set("I", i + 2, pcs[i].Motherboard.Manufacturer);

                            excel.Set("J", i + 2, pcs[i].InventoryNumber);
                        }

                        excel.Save();
                    }
                    MessageBox.Show("Успешно сохранено");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Call to developer");
            }
        }

        private void оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var excel = new ReportLogic())
                {
                    if (excel.Open(filePath: Path.Combine(Environment.CurrentDirectory, $"Отчет о ремонтированных в этом месяце компьютерах за {DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} {DateTime.Now.Hour}ч{DateTime.Now.Minute}м.xlsx")))
                    {

                        Context context = new Context();
                        List<PC> pcs = (from PC p in context.PCs join Repair r in context.Repairs on p.InventoryNumber equals r.Device.InventoryNumber
                                        where (((DateTime)r.EndDate).Month == DateTime.Now.Month)
                                        select p).ToList();


                        excel.Set("A", 1, "Сотрудник");
                        excel.Set("B", 1, "Процессор");
                        excel.Set("E", 1, "Жесткий диск");
                        excel.Set("H", 1, "Материнская плата");
                        excel.Set("J", 1, "Инвентарный номер");
                        for (int i = 0; i < pcs.Count; i++)
                        {
                            excel.Set("A", i + 2, pcs[i].Employee.FullName);

                            excel.Set("B", i + 2, pcs[i].Cpu.Name);
                            excel.Set("C", i + 2, pcs[i].Cpu.Frequency);
                            excel.Set("D", i + 2, pcs[i].Cpu.Manufacturer);

                            excel.Set("E", i + 2, pcs[i].Hdd.Name);
                            excel.Set("F", i + 2, pcs[i].Hdd.Volume);
                            excel.Set("G", i + 2, pcs[i].Hdd.Manufacturer);

                            excel.Set("H", i + 2, pcs[i].Motherboard.Name);
                            excel.Set("I", i + 2, pcs[i].Motherboard.Manufacturer);

                            excel.Set("J", i + 2, pcs[i].InventoryNumber);
                        }

                        excel.Save();
                    }
                    MessageBox.Show("Успешно сохранено");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Call to developer");
            }
        }
    }
}
