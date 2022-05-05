
namespace SiliconValley.Список_выставок
{
    partial class List_expos
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
            this.GridExpo = new System.Windows.Forms.DataGridView();
            this.ChangeExpo = new System.Windows.Forms.Button();
            this.DeleteExpo = new System.Windows.Forms.Button();
            this.AddExpo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridExpo)).BeginInit();
            this.SuspendLayout();
            // 
            // GridExpo
            // 
            this.GridExpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridExpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridExpo.Location = new System.Drawing.Point(187, 12);
            this.GridExpo.Name = "GridExpo";
            this.GridExpo.Size = new System.Drawing.Size(601, 426);
            this.GridExpo.TabIndex = 3;
            // 
            // ChangeExpo
            // 
            this.ChangeExpo.Location = new System.Drawing.Point(12, 92);
            this.ChangeExpo.Name = "ChangeExpo";
            this.ChangeExpo.Size = new System.Drawing.Size(159, 30);
            this.ChangeExpo.TabIndex = 4;
            this.ChangeExpo.Text = "Изменить выставку";
            this.ChangeExpo.UseVisualStyleBackColor = true;
            this.ChangeExpo.Click += new System.EventHandler(this.ChangeExpo_Click);
            // 
            // DeleteExpo
            // 
            this.DeleteExpo.Location = new System.Drawing.Point(12, 128);
            this.DeleteExpo.Name = "DeleteExpo";
            this.DeleteExpo.Size = new System.Drawing.Size(159, 30);
            this.DeleteExpo.TabIndex = 5;
            this.DeleteExpo.Text = "Удалить";
            this.DeleteExpo.UseVisualStyleBackColor = true;
            this.DeleteExpo.Click += new System.EventHandler(this.DeleteExpo_Click);
            // 
            // AddExpo
            // 
            this.AddExpo.Location = new System.Drawing.Point(12, 53);
            this.AddExpo.Name = "AddExpo";
            this.AddExpo.Size = new System.Drawing.Size(159, 30);
            this.AddExpo.TabIndex = 6;
            this.AddExpo.Text = "Добавить выставку";
            this.AddExpo.UseVisualStyleBackColor = true;
            this.AddExpo.Click += new System.EventHandler(this.AddExpo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // List_expos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddExpo);
            this.Controls.Add(this.DeleteExpo);
            this.Controls.Add(this.ChangeExpo);
            this.Controls.Add(this.GridExpo);
            this.Name = "List_expos";
            this.Text = "List_expos";
            this.Load += new System.EventHandler(this.List_expos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridExpo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridExpo;
        private System.Windows.Forms.Button ChangeExpo;
        private System.Windows.Forms.Button DeleteExpo;
        private System.Windows.Forms.Button AddExpo;
        private System.Windows.Forms.TextBox textBox1;
    }
}