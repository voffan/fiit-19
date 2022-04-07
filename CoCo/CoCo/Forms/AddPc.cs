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

namespace CoCo.Forms
{
    public partial class AddPc : Form
    {
        List<PC> PCs;
        public AddPc()
        {
            InitializeComponent();
        }

        private void AddPc_Load(object sender, EventArgs e)
        {
            PCs = new List<PC>();
            using (Context c = new Context())
            {
                comboBox1.DataSource = (from h in c.Hdds select new { Id = h.Id, Name = h.Name + " " + h.Volume + "ГБ " + h.Manufacturer }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";

                comboBox2.DataSource = (from cp in c.Cpus select new { Id = cp.Id, Name = cp.Name + " " + cp.Frequency + "ГГц " + cp.Manufacturer }).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";

                comboBox3.DataSource = (from m in c.Motherboards select new { Id = m.Id, Name = m.Name + " " + m.Manufacturer}).ToList();
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";

                comboBox4.DataSource = (from em in c.Employees select new {Id = em.Id,  Name = em.FullName + " " + em.DepartmentId + " отдел"}).ToList();
                comboBox4.DisplayMember = "Name";
                comboBox4.ValueMember = "Id";
               // comboBox1.Items.Add((from em in c.Employees select new { Id = em.Id, Name = em.FullName + " " + em.DepartmentId + "отдел" }).ToList()[i).Name;
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            Context context = new Context();
            PC pc = new PC();
            PC_Logic pC_Logic = new PC_Logic();
            
           /* int cpu = Convert.ToInt32(comboBox2.SelectedText.Split(' ')[0]);
            int mb = Convert.ToInt32(comboBox3.SelectedText.Split(' ')[0]);
            int em = Convert.ToInt32(comboBox4.SelectedText.Split(' ')[0]); */
            pc.HddId = (int)comboBox1.SelectedValue;
            pc.CpuId = (int)comboBox2.SelectedValue;
            pc.MotherboardId = (int)comboBox3.SelectedValue;
            pc.EmployeeId = (int)comboBox4.SelectedValue;

            pC_Logic.Add(pc.HddId, pc.CpuId, pc.MotherboardId, pc.EmployeeId);
                context.SaveChanges();
                Close();
    
        }
    }
}
