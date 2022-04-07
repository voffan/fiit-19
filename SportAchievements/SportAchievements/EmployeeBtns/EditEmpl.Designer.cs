
namespace SportAchievements.EmployeeBtns
{
    partial class EditEmpl
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
            this.lgn = new System.Windows.Forms.TextBox();
            this.psw = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.pos = new System.Windows.Forms.ComboBox();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lgn
            // 
            this.lgn.Location = new System.Drawing.Point(103, 59);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(266, 20);
            this.lgn.TabIndex = 14;
            // 
            // psw
            // 
            this.psw.Location = new System.Drawing.Point(103, 85);
            this.psw.Name = "psw";
            this.psw.Size = new System.Drawing.Size(266, 20);
            this.psw.TabIndex = 15;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(103, 111);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(266, 20);
            this.FIO.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата рожденя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Должность:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(103, 215);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 22;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(294, 215);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 23;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pos
            // 
            this.pos.FormattingEnabled = true;
            this.pos.Location = new System.Drawing.Point(103, 163);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(121, 21);
            this.pos.TabIndex = 24;
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(104, 137);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(265, 20);
            this.bdate.TabIndex = 25;
            // 
            // EditEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 284);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.psw);
            this.Controls.Add(this.lgn);
            this.Name = "EditEmpl";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditEmpl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lgn;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.DateTimePicker bdate;
    }
}