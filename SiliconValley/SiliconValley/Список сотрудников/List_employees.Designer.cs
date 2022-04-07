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
            this.gridEmployee = new System.Windows.Forms.DataGridView();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.ChangeEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmployee
            // 
            this.gridEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployee.Location = new System.Drawing.Point(296, 15);
            this.gridEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.RowHeadersWidth = 51;
            this.gridEmployee.Size = new System.Drawing.Size(755, 524);
            this.gridEmployee.TabIndex = 2;
            this.gridEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployee_CellContentClick);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(16, 15);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(243, 37);
            this.AddEmployee.TabIndex = 3;
            this.AddEmployee.Text = "Добавить сотрудника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // ChangeEmployee
            // 
            this.ChangeEmployee.Location = new System.Drawing.Point(16, 59);
            this.ChangeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeEmployee.Name = "ChangeEmployee";
            this.ChangeEmployee.Size = new System.Drawing.Size(243, 37);
            this.ChangeEmployee.TabIndex = 4;
            this.ChangeEmployee.Text = "Изменить данные сотрудника";
            this.ChangeEmployee.UseVisualStyleBackColor = true;
            this.ChangeEmployee.Click += new System.EventHandler(this.ChangeEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Location = new System.Drawing.Point(16, 104);
            this.deleteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(243, 37);
            this.deleteEmployee.TabIndex = 5;
            this.deleteEmployee.Text = "Удалить";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // List_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.ChangeEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.gridEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "List_employees";
            this.Text = "List_employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.List_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployee;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button ChangeEmployee;
        private System.Windows.Forms.Button deleteEmployee;
    }
}