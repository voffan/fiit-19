
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
            this.bibor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
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
            // bibor
            // 
            this.bibor.FormattingEnabled = true;
            this.bibor.Location = new System.Drawing.Point(296, 319);
            this.bibor.Name = "bibor";
            this.bibor.Size = new System.Drawing.Size(173, 21);
            this.bibor.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Поиск";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(138, 319);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(152, 20);
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // DovavitLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 378);
            this.Controls.Add(this.bibor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addlinkkindofsport);
            this.Controls.Add(this.Deletlinkkindofsport);
            this.Controls.Add(this.EditLinkkindofsport);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DovavitLink";
            this.Text = "Список видов спорта";
            this.Load += new System.EventHandler(this.LinkKindOfSport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditLinkkindofsport;
        private System.Windows.Forms.Button Deletlinkkindofsport;
        private System.Windows.Forms.Button addlinkkindofsport;
        private System.Windows.Forms.ComboBox bibor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}