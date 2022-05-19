
namespace SportAchievements.Links
{
    partial class LinkResult
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
            this.AddRes = new System.Windows.Forms.Button();
            this.EdRes = new System.Windows.Forms.Button();
            this.DelRes = new System.Windows.Forms.Button();
            this.bibor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddRes
            // 
            this.AddRes.Location = new System.Drawing.Point(12, 375);
            this.AddRes.Name = "AddRes";
            this.AddRes.Size = new System.Drawing.Size(75, 23);
            this.AddRes.TabIndex = 1;
            this.AddRes.Text = "Добавить";
            this.AddRes.UseVisualStyleBackColor = true;
            this.AddRes.Click += new System.EventHandler(this.AddRes_Click);
            // 
            // EdRes
            // 
            this.EdRes.Location = new System.Drawing.Point(607, 375);
            this.EdRes.Name = "EdRes";
            this.EdRes.Size = new System.Drawing.Size(75, 23);
            this.EdRes.TabIndex = 2;
            this.EdRes.Text = "Изменить";
            this.EdRes.UseVisualStyleBackColor = true;
            this.EdRes.Click += new System.EventHandler(this.EdRes_Click);
            // 
            // DelRes
            // 
            this.DelRes.Location = new System.Drawing.Point(713, 375);
            this.DelRes.Name = "DelRes";
            this.DelRes.Size = new System.Drawing.Size(75, 23);
            this.DelRes.TabIndex = 3;
            this.DelRes.Text = "Удалить";
            this.DelRes.UseVisualStyleBackColor = true;
            this.DelRes.Click += new System.EventHandler(this.DelRes_Click);
            // 
            // bibor
            // 
            this.bibor.FormattingEnabled = true;
            this.bibor.Location = new System.Drawing.Point(344, 373);
            this.bibor.Name = "bibor";
            this.bibor.Size = new System.Drawing.Size(173, 21);
            this.bibor.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Поиск";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(186, 373);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(152, 20);
            this.searchTextBox.TabIndex = 21;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // LinkResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bibor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.DelRes);
            this.Controls.Add(this.EdRes);
            this.Controls.Add(this.AddRes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LinkResult";
            this.Text = "LinkResult";
            this.Load += new System.EventHandler(this.LinkResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddRes;
        private System.Windows.Forms.Button EdRes;
        private System.Windows.Forms.Button DelRes;
        private System.Windows.Forms.ComboBox bibor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}