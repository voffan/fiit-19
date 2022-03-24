
namespace SportAchievements
{
    partial class DovavitLink
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
            this.EditLinkkindofsport = new System.Windows.Forms.Button();
            this.Deletlinkkindofsport = new System.Windows.Forms.Button();
            this.addlinkkindofsport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // EditLinkkindofsport
            // 
            this.EditLinkkindofsport.Location = new System.Drawing.Point(466, 280);
            this.EditLinkkindofsport.Name = "EditLinkkindofsport";
            this.EditLinkkindofsport.Size = new System.Drawing.Size(75, 23);
            this.EditLinkkindofsport.TabIndex = 2;
            this.EditLinkkindofsport.Text = "Изменить";
            this.EditLinkkindofsport.UseVisualStyleBackColor = true;
            this.EditLinkkindofsport.Click += new System.EventHandler(this.EditLinkkindofsport_Click);
            // 
            // Deletlinkkindofsport
            // 
            this.Deletlinkkindofsport.Location = new System.Drawing.Point(547, 280);
            this.Deletlinkkindofsport.Name = "Deletlinkkindofsport";
            this.Deletlinkkindofsport.Size = new System.Drawing.Size(75, 23);
            this.Deletlinkkindofsport.TabIndex = 3;
            this.Deletlinkkindofsport.Text = "Удалить";
            this.Deletlinkkindofsport.UseVisualStyleBackColor = true;
            this.Deletlinkkindofsport.Click += new System.EventHandler(this.Deletlinkkindofsport_Click);
            // 
            // addlinkkindofsport
            // 
            this.addlinkkindofsport.Location = new System.Drawing.Point(13, 280);
            this.addlinkkindofsport.Name = "addlinkkindofsport";
            this.addlinkkindofsport.Size = new System.Drawing.Size(75, 23);
            this.addlinkkindofsport.TabIndex = 4;
            this.addlinkkindofsport.Text = "Добавить";
            this.addlinkkindofsport.UseVisualStyleBackColor = true;
            this.addlinkkindofsport.Click += new System.EventHandler(this.addlinkkindofsport_Click);
            // 
            // DovavitLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 378);
            this.Controls.Add(this.addlinkkindofsport);
            this.Controls.Add(this.Deletlinkkindofsport);
            this.Controls.Add(this.EditLinkkindofsport);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DovavitLink";
            this.Text = "Список видов спорта";
            this.Load += new System.EventHandler(this.LinkKindOfSport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditLinkkindofsport;
        private System.Windows.Forms.Button Deletlinkkindofsport;
        private System.Windows.Forms.Button addlinkkindofsport;
    }
}