namespace CoCo
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
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компьютерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.периферияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матПлатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жДискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процессорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРаботающихКомпьютерахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСписанныхКомпьютерахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спискиToolStripMenuItem,
            this.составитьОтчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компьютерыToolStripMenuItem,
            this.периферияToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.отделыToolStripMenuItem,
            this.компонентыToolStripMenuItem,
            this.ремонтыToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // компьютерыToolStripMenuItem
            // 
            this.компьютерыToolStripMenuItem.Name = "компьютерыToolStripMenuItem";
            this.компьютерыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.компьютерыToolStripMenuItem.Text = "Компьютеры";
            this.компьютерыToolStripMenuItem.Click += new System.EventHandler(this.компьютерыToolStripMenuItem_Click);
            // 
            // периферияToolStripMenuItem
            // 
            this.периферияToolStripMenuItem.Name = "периферияToolStripMenuItem";
            this.периферияToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.периферияToolStripMenuItem.Text = "Периферия";
            this.периферияToolStripMenuItem.Click += new System.EventHandler(this.периферияToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.отделыToolStripMenuItem.Text = "Отделы";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матПлатыToolStripMenuItem,
            this.жДискиToolStripMenuItem,
            this.процессорыToolStripMenuItem});
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            // 
            // матПлатыToolStripMenuItem
            // 
            this.матПлатыToolStripMenuItem.Name = "матПлатыToolStripMenuItem";
            this.матПлатыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.матПлатыToolStripMenuItem.Text = "Мат платы";
            this.матПлатыToolStripMenuItem.Click += new System.EventHandler(this.матПлатыToolStripMenuItem_Click);
            // 
            // жДискиToolStripMenuItem
            // 
            this.жДискиToolStripMenuItem.Name = "жДискиToolStripMenuItem";
            this.жДискиToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.жДискиToolStripMenuItem.Text = "Ж диски";
            this.жДискиToolStripMenuItem.Click += new System.EventHandler(this.жДискиToolStripMenuItem_Click);
            // 
            // процессорыToolStripMenuItem
            // 
            this.процессорыToolStripMenuItem.Name = "процессорыToolStripMenuItem";
            this.процессорыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.процессорыToolStripMenuItem.Text = "Процессоры";
            this.процессорыToolStripMenuItem.Click += new System.EventHandler(this.процессорыToolStripMenuItem_Click);
            // 
            // ремонтыToolStripMenuItem
            // 
            this.ремонтыToolStripMenuItem.Name = "ремонтыToolStripMenuItem";
            this.ремонтыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ремонтыToolStripMenuItem.Text = "Ремонты";
            this.ремонтыToolStripMenuItem.Click += new System.EventHandler(this.ремонтыToolStripMenuItem_Click);
            // 
            // составитьОтчетToolStripMenuItem
            // 
            this.составитьОтчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРаботающихКомпьютерахToolStripMenuItem,
            this.оСписанныхКомпьютерахToolStripMenuItem,
            this.оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem});
            this.составитьОтчетToolStripMenuItem.Name = "составитьОтчетToolStripMenuItem";
            this.составитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.составитьОтчетToolStripMenuItem.Text = "Составить отчет";
            // 
            // оРаботающихКомпьютерахToolStripMenuItem
            // 
            this.оРаботающихКомпьютерахToolStripMenuItem.Name = "оРаботающихКомпьютерахToolStripMenuItem";
            this.оРаботающихКомпьютерахToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.оРаботающихКомпьютерахToolStripMenuItem.Text = "О работающих компьютерах";
            this.оРаботающихКомпьютерахToolStripMenuItem.Click += new System.EventHandler(this.оРаботающихКомпьютерахToolStripMenuItem_Click);
            // 
            // оСписанныхКомпьютерахToolStripMenuItem
            // 
            this.оСписанныхКомпьютерахToolStripMenuItem.Name = "оСписанныхКомпьютерахToolStripMenuItem";
            this.оСписанныхКомпьютерахToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.оСписанныхКомпьютерахToolStripMenuItem.Text = "О списанных компьютерах";
            this.оСписанныхКомпьютерахToolStripMenuItem.Click += new System.EventHandler(this.оСписанныхКомпьютерахToolStripMenuItem_Click);
            // 
            // оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem
            // 
            this.оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem.Name = "оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem";
            this.оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem.Text = "О ремонтированных в этом месяце компьютерах";
            this.оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem.Click += new System.EventHandler(this.оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 567);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CoCo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компьютерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem периферияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матПлатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жДискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процессорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ремонтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составитьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРаботающихКомпьютерахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСписанныхКомпьютерахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРемонтированныхВЭтомМесяцеКомпьютерахToolStripMenuItem;
    }
}

