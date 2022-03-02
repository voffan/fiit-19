
namespace SportAchievements
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСпортсменовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСоревнованийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВидовСпортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокОтчетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСпортсменовToolStripMenuItem,
            this.списокСоревнованийToolStripMenuItem,
            this.списокСотрудниковToolStripMenuItem,
            this.списокВидовСпортаToolStripMenuItem,
            this.списокОтчетовToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // списокСпортсменовToolStripMenuItem
            // 
            this.списокСпортсменовToolStripMenuItem.Name = "списокСпортсменовToolStripMenuItem";
            this.списокСпортсменовToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.списокСпортсменовToolStripMenuItem.Text = "Список спортсменов";
            this.списокСпортсменовToolStripMenuItem.Click += new System.EventHandler(this.списокСпортсменовToolStripMenuItem_Click);
            // 
            // списокСоревнованийToolStripMenuItem
            // 
            this.списокСоревнованийToolStripMenuItem.Name = "списокСоревнованийToolStripMenuItem";
            this.списокСоревнованийToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.списокСоревнованийToolStripMenuItem.Text = "Список соревнований";
            this.списокСоревнованийToolStripMenuItem.Click += new System.EventHandler(this.списокСоревнованийToolStripMenuItem_Click);
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            this.списокСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.списокСотрудниковToolStripMenuItem_Click);
            // 
            // списокВидовСпортаToolStripMenuItem
            // 
            this.списокВидовСпортаToolStripMenuItem.Name = "списокВидовСпортаToolStripMenuItem";
            this.списокВидовСпортаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.списокВидовСпортаToolStripMenuItem.Text = "Список видов спорта";
            this.списокВидовСпортаToolStripMenuItem.Click += new System.EventHandler(this.списокВидовСпортаToolStripMenuItem_Click);
            // 
            // списокОтчетовToolStripMenuItem
            // 
            this.списокОтчетовToolStripMenuItem.Name = "списокОтчетовToolStripMenuItem";
            this.списокОтчетовToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.списокОтчетовToolStripMenuItem.Text = "Список отчетов";
            this.списокОтчетовToolStripMenuItem.Click += new System.EventHandler(this.списокОтчетовToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 430);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСпортсменовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСоревнованийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВидовСпортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокОтчетовToolStripMenuItem;
    }
}

