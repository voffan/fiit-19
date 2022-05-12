
namespace SportAchievements.ResultBtns
{
    partial class EditResult
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
            this.Points = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.NumericUpDown();
            this.vesovkat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vitsporta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Place)).BeginInit();
            this.SuspendLayout();
            // 
            // Points
            // 
            this.Points.Location = new System.Drawing.Point(12, 175);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(153, 20);
            this.Points.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Баллы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Место";
            // 
            // Place
            // 
            this.Place.Location = new System.Drawing.Point(12, 125);
            this.Place.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(153, 20);
            this.Place.TabIndex = 16;
            this.Place.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // vesovkat
            // 
            this.vesovkat.FormattingEnabled = true;
            this.vesovkat.Location = new System.Drawing.Point(12, 75);
            this.vesovkat.Name = "vesovkat";
            this.vesovkat.Size = new System.Drawing.Size(308, 21);
            this.vesovkat.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Весовая категория";
            // 
            // vitsporta
            // 
            this.vitsporta.FormattingEnabled = true;
            this.vitsporta.Location = new System.Drawing.Point(12, 25);
            this.vitsporta.Name = "vitsporta";
            this.vitsporta.Size = new System.Drawing.Size(308, 21);
            this.vitsporta.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Выберите вид спорта";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(248, 241);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(15, 241);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 20;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EditResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 276);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.vesovkat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vitsporta);
            this.Controls.Add(this.label3);
            this.Name = "EditResult";
            this.Text = "EditResult";
            this.Load += new System.EventHandler(this.EditResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Place)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Points;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Place;
        private System.Windows.Forms.ComboBox vesovkat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vitsporta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}