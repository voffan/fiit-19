
namespace SportAchievements
{
    partial class AddKindOfSport
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
            this.dovavitkindofsport = new System.Windows.Forms.Button();
            this.otmenakindofsport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dovavitkindofsport
            // 
            this.dovavitkindofsport.Location = new System.Drawing.Point(25, 88);
            this.dovavitkindofsport.Name = "dovavitkindofsport";
            this.dovavitkindofsport.Size = new System.Drawing.Size(75, 23);
            this.dovavitkindofsport.TabIndex = 0;
            this.dovavitkindofsport.Text = "Добавить";
            this.dovavitkindofsport.UseVisualStyleBackColor = true;
            this.dovavitkindofsport.Click += new System.EventHandler(this.dovavitkindofsport_Click);
            // 
            // otmenakindofsport
            // 
            this.otmenakindofsport.Location = new System.Drawing.Point(222, 88);
            this.otmenakindofsport.Name = "otmenakindofsport";
            this.otmenakindofsport.Size = new System.Drawing.Size(75, 23);
            this.otmenakindofsport.TabIndex = 1;
            this.otmenakindofsport.Text = "Отмена";
            this.otmenakindofsport.UseVisualStyleBackColor = true;
            this.otmenakindofsport.Click += new System.EventHandler(this.otmenakindofsport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(88, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(209, 20);
            this.name.TabIndex = 19;
            // 
            // AddKindOfSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 145);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otmenakindofsport);
            this.Controls.Add(this.dovavitkindofsport);
            this.Name = "AddKindOfSport";
            this.Text = "Добавление вида спорта";
            this.Load += new System.EventHandler(this.AddKindOfSport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dovavitkindofsport;
        private System.Windows.Forms.Button otmenakindofsport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
    }
}