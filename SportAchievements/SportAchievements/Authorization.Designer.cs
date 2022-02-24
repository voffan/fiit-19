
namespace SportAchievements
{
    partial class Authorization
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
            this.txtLgn = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PswLbl = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLgn
            // 
            this.txtLgn.Location = new System.Drawing.Point(130, 101);
            this.txtLgn.Name = "txtLgn";
            this.txtLgn.Size = new System.Drawing.Size(240, 20);
            this.txtLgn.TabIndex = 0;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(198, 183);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(130, 137);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(240, 20);
            this.txtPsw.TabIndex = 2;
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(83, 104);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(41, 13);
            this.LoginLbl.TabIndex = 3;
            this.LoginLbl.Text = "Логин:";
            // 
            // PswLbl
            // 
            this.PswLbl.AutoSize = true;
            this.PswLbl.Location = new System.Drawing.Point(76, 140);
            this.PswLbl.Name = "PswLbl";
            this.PswLbl.Size = new System.Drawing.Size(48, 13);
            this.PswLbl.TabIndex = 4;
            this.PswLbl.Text = "Пароль:";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(153, 59);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(189, 13);
            this.Welcome.TabIndex = 5;
            this.Welcome.Text = "Добро пожаловать! Авторизуйтесь.";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(198, 212);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 258);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.PswLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.txtLgn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLgn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Label PswLbl;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button CancelBtn;
    }
}