﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportAchievements.Links;

namespace SportAchievements
{
    public partial class MainMenu : Form
    {
        public Context context = new Context();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void списокСпортсменовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkSportsman Sportsman = new LinkSportsman();
            Sportsman.MdiParent = this;
            Sportsman.Show();
        }

        private void списокСоревнованийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkCompetition Competition = new LinkCompetition();
            Competition.MdiParent = this;
            Competition.Show();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkEmployee Employee = new LinkEmployee();
            Employee.MdiParent = this;
            Employee.Show();
        }

        private void списокВидовСпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DovavitLink KindOfSport = new DovavitLink();
            KindOfSport.MdiParent = this;
            KindOfSport.Show();
        }

        private void списокОтчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkReport Report = new LinkReport();
            Report.MdiParent = this;
            Report.Show();
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkResult Result = new LinkResult();
            Result.MdiParent = this;
            Result.Show();
        }
    }
}
