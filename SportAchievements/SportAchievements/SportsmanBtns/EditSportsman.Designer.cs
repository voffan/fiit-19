
namespace SportAchievements.SportsmanBtns
{
    partial class EditSportsman
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.gen = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(123, 97);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(265, 20);
            this.bdate.TabIndex = 35;
            // 
            // gen
            // 
            this.gen.FormattingEnabled = true;
            this.gen.Location = new System.Drawing.Point(122, 123);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(121, 21);
            this.gen.TabIndex = 34;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(312, 203);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 33;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(78, 203);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 32;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(86, 126);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(30, 13);
            this.Gender.TabIndex = 31;
            this.Gender.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Дата рожденя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ФИО:";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(12, 151);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(108, 13);
            this.weight.TabIndex = 28;
            this.weight.Text = "Весовая категория:";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(122, 71);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(266, 20);
            this.FIO.TabIndex = 27;
            // 
            // EditSportsman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 271);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.FIO);
            this.Name = "EditSportsman";
            this.Text = "EditSportsman";
            this.Load += new System.EventHandler(this.EditSportsman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox FIO;
    }
}