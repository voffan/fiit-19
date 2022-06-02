namespace CoCo.Forms
{
    partial class ChangeCpu
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
            this.textBoxManu = new System.Windows.Forms.TextBox();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_freq = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxManu
            // 
            this.textBoxManu.Location = new System.Drawing.Point(155, 105);
            this.textBoxManu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxManu.Name = "textBoxManu";
            this.textBoxManu.Size = new System.Drawing.Size(257, 22);
            this.textBoxManu.TabIndex = 16;
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(155, 70);
            this.textBoxFreq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(257, 22);
            this.textBoxFreq.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(155, 36);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(257, 22);
            this.textBoxName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Производитель";
            // 
            // label_freq
            // 
            this.label_freq.AutoSize = true;
            this.label_freq.Location = new System.Drawing.Point(25, 77);
            this.label_freq.Name = "label_freq";
            this.label_freq.Size = new System.Drawing.Size(61, 16);
            this.label_freq.TabIndex = 12;
            this.label_freq.Text = "Частота";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(25, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(73, 16);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Название";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 198);
            this.Controls.Add(this.textBoxManu);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_freq);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeCpu";
            this.Text = "Изменить процессор";
            this.Load += new System.EventHandler(this.ChangeCpu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxManu;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_freq;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}