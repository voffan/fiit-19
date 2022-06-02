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

    public partial class ChangePC : Form
    {
        readonly int pcId;
        int hddid, cpuid, mbid, eid;
        Status status;
        string invn;
        public ChangePC(int _pc)
        {
            InitializeComponent();
            pcId = _pc;
            PC pc = PCLogic.Get(pcId);
            hddid = pc.HddId;
            cpuid = pc.CpuId;
            mbid = pc.MotherboardId;
            eid = pc.EmployeeId;
            status = pc.Status;
            invn = pc.InventoryNumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = PCLogic.InvNumber(pcId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int hdd = (int)comboBox1.SelectedValue;
                int cpu = (int)comboBox2.SelectedValue;
                int motherboard = (int)comboBox3.SelectedValue;
                int empl = (int)comboBox4.SelectedValue;
                Status status = (Status)Enum.Parse(typeof(Status), (string)comboBox5.SelectedValue);
                string invn = textBox1.Text;

                if (this.status != status)
                {
                    if (this.status == Status.repairing)
                    {
                        if (status == Status.working)
                            RepairLogic.Complete(pcId, RepairStatus.done);
                        else if (status == Status.broken || status == Status.writtenoff)
                            RepairLogic.Complete(pcId, RepairStatus.failed);
                    }
                        
                        else if (this.status == Status.working || this.status == Status.broken)
                            if (status == Status.repairing)
                            {
                                AddRepair addRepair = new AddRepair(pcId);
                                addRepair.Show();
                            }
                }
                    PCLogic.PCChange(hdd, cpu, motherboard, empl, pcId, status, invn);
                    Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangePC_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                comboBox1.DataSource = (from hdd in c.Hdds select new { hdd.Id, Name = hdd.Name + " " + hdd.Manufacturer + " " + hdd.Volume + "ГБ" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox1.SelectedValue = hddid;

                comboBox2.DataSource = (from cpu in c.Cpus select new { cpu.Id, Name = cpu.Name + " " + cpu.Manufacturer + " " + cpu.Frequency }).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
                comboBox2.SelectedValue = cpuid;

                comboBox3.DataSource = (from mth in c.Motherboards select new { mth.Id, Name = mth.Name + " " + mth.Manufacturer }).ToList();
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";
                comboBox3.SelectedValue = mbid;

                comboBox4.DataSource = (from em in c.Employees select new { em.Id, Name = em.FullName + ", " + em.DepartmentId + " отдел" }).ToList();
                comboBox4.DisplayMember = "Name";
                comboBox4.ValueMember = "Id";
                comboBox4.SelectedValue = eid;
            }
            comboBox5.DataSource = new BindingSource(DescriptionAttributes<Status>.RetrieveAttributes(), null);
            comboBox5.DisplayMember = "Key";
            comboBox5.ValueMember = "Value";
            comboBox5.SelectedIndex = (int)status;
            textBox1.Text = invn;
        }
    } 
}

