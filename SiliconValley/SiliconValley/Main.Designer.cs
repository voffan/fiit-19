
namespace SiliconValley
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКартинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВыставокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВыставокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАвторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКартинToolStripMenuItem,
            this.списокВыставокToolStripMenuItem,
            this.списокВыставокToolStripMenuItem1,
            this.списокАвторовToolStripMenuItem,
            this.listGenreToolStripMenuItem,
            this.listEmployeeToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // списокКартинToolStripMenuItem
            // 
            this.списокКартинToolStripMenuItem.Name = "списокКартинToolStripMenuItem";
            this.списокКартинToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокКартинToolStripMenuItem.Text = "Список картин";
            this.списокКартинToolStripMenuItem.Click += new System.EventHandler(this.списокКартинToolStripMenuItem_Click);
            // 
            // списокВыставокToolStripMenuItem
            // 
            this.списокВыставокToolStripMenuItem.Name = "списокВыставокToolStripMenuItem";
            this.списокВыставокToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокВыставокToolStripMenuItem.Text = "Список отделов";
            this.списокВыставокToolStripMenuItem.Click += new System.EventHandler(this.списокВыставокToolStripMenuItem_Click);
            // 
            // списокВыставокToolStripMenuItem1
            // 
            this.списокВыставокToolStripMenuItem1.Name = "списокВыставокToolStripMenuItem1";
            this.списокВыставокToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.списокВыставокToolStripMenuItem1.Text = "Список выставок";
            this.списокВыставокToolStripMenuItem1.Click += new System.EventHandler(this.списокВыставокToolStripMenuItem1_Click);
            // 
            // списокАвторовToolStripMenuItem
            // 
            this.списокАвторовToolStripMenuItem.Name = "списокАвторовToolStripMenuItem";
            this.списокАвторовToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокАвторовToolStripMenuItem.Text = "Список авторов";
            this.списокАвторовToolStripMenuItem.Click += new System.EventHandler(this.списокАвторовToolStripMenuItem_Click);
            // 
            // listGenreToolStripMenuItem
            // 
            this.listGenreToolStripMenuItem.Name = "listGenreToolStripMenuItem";
            this.listGenreToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listGenreToolStripMenuItem.Text = "Список жанров";
            this.listGenreToolStripMenuItem.Click += new System.EventHandler(this.listGenreToolStripMenuItem_Click);
            // 
            // listEmployeeToolStripMenuItem
            // 
            this.listEmployeeToolStripMenuItem.Name = "listEmployeeToolStripMenuItem";
            this.listEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listEmployeeToolStripMenuItem.Text = "Список сотрудников";
            this.listEmployeeToolStripMenuItem.Visible = false;
            this.listEmployeeToolStripMenuItem.Click += new System.EventHandler(this.списокСотрудниковToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Gallery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКартинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВыставокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВыставокToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокАвторовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}