
namespace SportAchievements
{
    partial class AddCompetition
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
            this.addEmpl = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeid = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.typeid)).BeginInit();
            this.SuspendLayout();
            // 
            // addEmpl
            // 
            this.addEmpl.Location = new System.Drawing.Point(77, 266);
            this.addEmpl.Name = "addEmpl";
            this.addEmpl.Size = new System.Drawing.Size(75, 23);
            this.addEmpl.TabIndex = 11;
            this.addEmpl.Text = "Добавить";
            this.addEmpl.UseVisualStyleBackColor = true;
            this.addEmpl.Click += new System.EventHandler(this.addEmpl_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(272, 266);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(108, 117);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(265, 20);
            this.end.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата окончания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата начала:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(108, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(266, 20);
            this.name.TabIndex = 14;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(108, 88);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(265, 20);
            this.start.TabIndex = 24;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(107, 169);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(266, 20);
            this.type.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Тип спорта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Вид спорта:";
            // 
            // typeid
            // 
            this.typeid.Location = new System.Drawing.Point(108, 143);
            this.typeid.Name = "typeid";
            this.typeid.Size = new System.Drawing.Size(120, 20);
            this.typeid.TabIndex = 29;
            // 
            // AddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 358);
            this.Controls.Add(this.typeid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type);
            this.Controls.Add(this.start);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.addEmpl);
            this.Name = "AddCompetition";
            this.Text = "AddCompetition";
            this.Load += new System.EventHandler(this.AddCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmpl;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown typeid;
    }
}