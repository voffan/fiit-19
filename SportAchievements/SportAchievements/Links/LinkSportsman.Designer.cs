
namespace SportAchievements
{
    partial class LinkSportsman
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
            this.AddSprtsmn = new System.Windows.Forms.Button();
            this.Edit_Sprtsmn = new System.Windows.Forms.Button();
            this.Del_Sprtsmn = new System.Windows.Forms.Button();
            this.bibor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddSprtsmn
            // 
            this.AddSprtsmn.Location = new System.Drawing.Point(23, 328);
            this.AddSprtsmn.Name = "AddSprtsmn";
            this.AddSprtsmn.Size = new System.Drawing.Size(75, 23);
            this.AddSprtsmn.TabIndex = 1;
            this.AddSprtsmn.Text = "Добавить";
            this.AddSprtsmn.UseVisualStyleBackColor = true;
            this.AddSprtsmn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit_Sprtsmn
            // 
            this.Edit_Sprtsmn.Location = new System.Drawing.Point(481, 328);
            this.Edit_Sprtsmn.Name = "Edit_Sprtsmn";
            this.Edit_Sprtsmn.Size = new System.Drawing.Size(75, 23);
            this.Edit_Sprtsmn.TabIndex = 2;
            this.Edit_Sprtsmn.Text = "Изменить";
            this.Edit_Sprtsmn.UseVisualStyleBackColor = true;
            this.Edit_Sprtsmn.Click += new System.EventHandler(this.Edit_Sprtsmn_Click);
            // 
            // Del_Sprtsmn
            // 
            this.Del_Sprtsmn.Location = new System.Drawing.Point(590, 328);
            this.Del_Sprtsmn.Name = "Del_Sprtsmn";
            this.Del_Sprtsmn.Size = new System.Drawing.Size(75, 23);
            this.Del_Sprtsmn.TabIndex = 3;
            this.Del_Sprtsmn.Text = "Удалить";
            this.Del_Sprtsmn.UseVisualStyleBackColor = true;
            this.Del_Sprtsmn.Click += new System.EventHandler(this.Del_Sprtsmn_Click);
            // 
            // bibor
            // 
            this.bibor.FormattingEnabled = true;
            this.bibor.Location = new System.Drawing.Point(306, 369);
            this.bibor.Name = "bibor";
            this.bibor.Size = new System.Drawing.Size(173, 21);
            this.bibor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Поиск";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(148, 369);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(152, 20);
            this.searchTextBox.TabIndex = 18;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // LinkSportsman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 420);
            this.Controls.Add(this.bibor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.Del_Sprtsmn);
            this.Controls.Add(this.Edit_Sprtsmn);
            this.Controls.Add(this.AddSprtsmn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LinkSportsman";
            this.Text = "Список спортсменов";
            this.Load += new System.EventHandler(this.LinkSportsman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddSprtsmn;
        private System.Windows.Forms.Button Edit_Sprtsmn;
        private System.Windows.Forms.Button Del_Sprtsmn;
        private System.Windows.Forms.ComboBox bibor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}