namespace SiliconValley.Список_сотрдников
{
    partial class List_employees
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
            this.gridGenre = new System.Windows.Forms.DataGridView();
            this.AddGenre = new System.Windows.Forms.Button();
            this.ChangeGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGenre
            // 
            this.gridGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGenre.Location = new System.Drawing.Point(222, 12);
            this.gridGenre.Name = "gridGenre";
            this.gridGenre.RowHeadersWidth = 51;
            this.gridGenre.Size = new System.Drawing.Size(566, 426);
            this.gridGenre.TabIndex = 2;
            // 
            // AddGenre
            // 
            this.AddGenre.Location = new System.Drawing.Point(12, 12);
            this.AddGenre.Name = "AddGenre";
            this.AddGenre.Size = new System.Drawing.Size(182, 30);
            this.AddGenre.TabIndex = 3;
            this.AddGenre.Text = "Добавить сотрудника";
            this.AddGenre.UseVisualStyleBackColor = true;
            this.AddGenre.Click += new System.EventHandler(this.AddGenre_Click);
            // 
            // ChangeGenre
            // 
            this.ChangeGenre.Location = new System.Drawing.Point(12, 48);
            this.ChangeGenre.Name = "ChangeGenre";
            this.ChangeGenre.Size = new System.Drawing.Size(182, 30);
            this.ChangeGenre.TabIndex = 4;
            this.ChangeGenre.Text = "Изменить данные сотрудника";
            this.ChangeGenre.UseVisualStyleBackColor = true;
            // 
            // List_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeGenre);
            this.Controls.Add(this.AddGenre);
            this.Controls.Add(this.gridGenre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "List_employees";
            this.Text = "List_employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.List_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridGenre;
        private System.Windows.Forms.Button AddGenre;
        private System.Windows.Forms.Button ChangeGenre;
    }
}