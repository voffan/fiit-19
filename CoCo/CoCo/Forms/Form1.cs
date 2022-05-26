using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = ExcelLibrary;
using CoCo.Classes;

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
            /*           ExcelLibrary.SpreadSheet ex = new Excel.Application();
                       ex.SheetsInNewWorkbook = 1;
                       Workbook workBook = ex.Workbooks.Add(Type.Missing);
                       ex.DisplayAlerts = false;
                       ExcelLibrary.SpreadSheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
                       sheet.Name = "Отчет о работающих компьютерах от " + DateTime.Today.ToString();
                       Context context = new Context();
                       List<PC> pcs = (from PC d in context.PCs
                                   where d.Status == Status.working
                                   select d).ToList();
                       for(int i = 0; i < pcs.Count; i++)
                       {
                           sheet.Cells[i, 1] = pcs[i].Id;
                       }
                       context.Dispose();*/
        }
    }
}
