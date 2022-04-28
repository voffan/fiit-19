
namespace SportAchievements.ResultBtns
{
    partial class AddResult
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
            this.sportsman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.competition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sportsman
            // 
            this.sportsman.FormattingEnabled = true;
            this.sportsman.Location = new System.Drawing.Point(12, 60);
            this.sportsman.Name = "sportsman";
            this.sportsman.Size = new System.Drawing.Size(308, 21);
            this.sportsman.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите спортсмена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите соревнование:";
            // 
            // competition
            // 
            this.competition.FormattingEnabled = true;
            this.competition.Location = new System.Drawing.Point(12, 112);
            this.competition.Name = "competition";
            this.competition.Size = new System.Drawing.Size(308, 21);
            this.competition.TabIndex = 2;
            // 
            // AddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.competition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sportsman);
            this.Name = "AddResult";
            this.Text = "AddResult";
            this.Load += new System.EventHandler(this.AddResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sportsman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox competition;
    }
}