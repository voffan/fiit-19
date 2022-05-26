
namespace SportAchievements
{
    partial class LinkReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Apply = new System.Windows.Forms.Button();
            this.Report1 = new System.Windows.Forms.RadioButton();
            this.Report2 = new System.Windows.Forms.RadioButton();
            this.sportKind = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(667, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(278, 448);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(133, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Сформировать отчет";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Report1_Click);
            // 
            // Report1
            // 
            this.Report1.AutoSize = true;
            this.Report1.Location = new System.Drawing.Point(12, 323);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(451, 17);
            this.Report1.TabIndex = 3;
            this.Report1.TabStop = true;
            this.Report1.Text = "Спортсмены с наибольшим количеством призовых мест по заданному виду спорта";
            this.Report1.UseVisualStyleBackColor = true;
            this.Report1.CheckedChanged += new System.EventHandler(this.Report1_CheckedChanged);
            // 
            // Report2
            // 
            this.Report2.AutoSize = true;
            this.Report2.Location = new System.Drawing.Point(12, 346);
            this.Report2.Name = "Report2";
            this.Report2.Size = new System.Drawing.Size(377, 17);
            this.Report2.TabIndex = 4;
            this.Report2.TabStop = true;
            this.Report2.Text = "Победители по заданному виду спорта за заданный период времени";
            this.Report2.UseVisualStyleBackColor = true;
            this.Report2.CheckedChanged += new System.EventHandler(this.Report2_CheckedChanged);
            // 
            // sportKind
            // 
            this.sportKind.FormattingEnabled = true;
            this.sportKind.Location = new System.Drawing.Point(143, 377);
            this.sportKind.Name = "sportKind";
            this.sportKind.Size = new System.Drawing.Size(121, 21);
            this.sportKind.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 415);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(417, 415);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вид спорта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Начало:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Конец:";
            // 
            // LinkReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sportKind);
            this.Controls.Add(this.Report2);
            this.Controls.Add(this.Report1);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LinkReport";
            this.Text = "Список отчетов";
            this.Load += new System.EventHandler(this.LinkReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.RadioButton Report1;
        private System.Windows.Forms.RadioButton Report2;
        private System.Windows.Forms.ComboBox sportKind;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}