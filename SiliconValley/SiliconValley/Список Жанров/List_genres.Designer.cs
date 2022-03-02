namespace SiliconValley.Список_Жанров
{
    partial class List_genres
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
            this.gridGenre.Location = new System.Drawing.Point(296, 15);
            this.gridGenre.Margin = new System.Windows.Forms.Padding(4);
            this.gridGenre.Name = "gridGenre";
            this.gridGenre.RowHeadersWidth = 51;
            this.gridGenre.Size = new System.Drawing.Size(755, 524);
            this.gridGenre.TabIndex = 1;
            this.gridGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGenre_CellContentClick);
            // 
            // AddGenre
            // 
            this.AddGenre.Location = new System.Drawing.Point(16, 15);
            this.AddGenre.Margin = new System.Windows.Forms.Padding(4);
            this.AddGenre.Name = "AddGenre";
            this.AddGenre.Size = new System.Drawing.Size(243, 37);
            this.AddGenre.TabIndex = 2;
            this.AddGenre.Text = "Добавить жанр";
            this.AddGenre.UseVisualStyleBackColor = true;
            this.AddGenre.Click += new System.EventHandler(this.AddGenre_Click);
            // 
            // ChangeGenre
            // 
            this.ChangeGenre.Location = new System.Drawing.Point(16, 59);
            this.ChangeGenre.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeGenre.Name = "ChangeGenre";
            this.ChangeGenre.Size = new System.Drawing.Size(243, 37);
            this.ChangeGenre.TabIndex = 3;
            this.ChangeGenre.Text = "Изменить жанр";
            this.ChangeGenre.UseVisualStyleBackColor = true;
            this.ChangeGenre.Click += new System.EventHandler(this.ChangeGenre_Click);
            // 
            // List_genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ChangeGenre);
            this.Controls.Add(this.AddGenre);
            this.Controls.Add(this.gridGenre);
            this.Name = "List_genres";
            this.Text = "List_genres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.List_genres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridGenre;
        private System.Windows.Forms.Button AddGenre;
        private System.Windows.Forms.Button ChangeGenre;
    }
}