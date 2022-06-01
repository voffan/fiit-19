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
            this.label_manu = new System.Windows.Forms.Label();
            this.label_freq = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxManu
            // 
            this.textBoxManu.Location = new System.Drawing.Point(118, 76);
            this.textBoxManu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxManu.Name = "textBoxManu";
            this.textBoxManu.Size = new System.Drawing.Size(200, 20);
            this.textBoxManu.TabIndex = 16;
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(118, 48);
            this.textBoxFreq.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(200, 20);
            this.textBoxFreq.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 20);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // label_manu
            // 
            this.label_manu.AutoSize = true;
            this.label_manu.Location = new System.Drawing.Point(11, 79);
            this.label_manu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_manu.Name = "label_manu";
            this.label_manu.Size = new System.Drawing.Size(86, 13);
            this.label_manu.TabIndex = 13;
            this.label_manu.Text = "Производитель";
            // 
            // label_freq
            // 
            this.label_freq.AutoSize = true;
            this.label_freq.Location = new System.Drawing.Point(11, 51);
            this.label_freq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_freq.Name = "label_freq";
            this.label_freq.Size = new System.Drawing.Size(49, 13);
            this.label_freq.TabIndex = 12;
            this.label_freq.Text = "Частота";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(11, 23);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 13);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Название";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(262, 119);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(56, 19);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(187, 119);
            this.button_change.Margin = new System.Windows.Forms.Padding(2);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(70, 19);
            this.button_change.TabIndex = 9;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 157);
            this.Controls.Add(this.textBoxManu);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label_manu);
            this.Controls.Add(this.label_freq);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_change);
            this.Name = "ChangeCpu";
            this.Text = "ChangeCpu";
            this.Load += new System.EventHandler(this.ChangeCpu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxManu;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_manu;
        private System.Windows.Forms.Label label_freq;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_change;
    }
}