namespace AdminTB
{
    partial class LoginForm
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
            this.Authorization = new System.Windows.Forms.Label();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrationUser = new System.Windows.Forms.LinkLabel();
            this.EraserPictBtn = new System.Windows.Forms.PictureBox();
            this.UserLogIn = new System.Windows.Forms.PictureBox();
            this.VisiblePassword = new System.Windows.Forms.PictureBox();
            this.UnvisiblePassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EraserPictBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnvisiblePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // Authorization
            // 
            this.Authorization.AutoSize = true;
            this.Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization.Location = new System.Drawing.Point(94, 31);
            this.Authorization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(211, 37);
            this.Authorization.TabIndex = 1;
            this.Authorization.Text = "Авторизация";
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInLabel.Location = new System.Drawing.Point(124, 139);
            this.LogInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(78, 26);
            this.LogInLabel.TabIndex = 2;
            this.LogInLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(110, 188);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(95, 26);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LogInTextBox.Location = new System.Drawing.Point(205, 136);
            this.LogInTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogInTextBox.MaxLength = 50;
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(258, 32);
            this.LogInTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.PasswordTextBox.Location = new System.Drawing.Point(205, 188);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(258, 32);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button1.Location = new System.Drawing.Point(258, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationUser
            // 
            this.RegistrationUser.AutoSize = true;
            this.RegistrationUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationUser.LinkColor = System.Drawing.Color.Gray;
            this.RegistrationUser.Location = new System.Drawing.Point(250, 318);
            this.RegistrationUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationUser.Name = "RegistrationUser";
            this.RegistrationUser.Size = new System.Drawing.Size(138, 18);
            this.RegistrationUser.TabIndex = 7;
            this.RegistrationUser.TabStop = true;
            this.RegistrationUser.Text = "Ещё нет аккаунта?";
            this.RegistrationUser.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegistrationUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationUser_LinkClicked);
            // 
            // EraserPictBtn
            // 
            this.EraserPictBtn.Image = global::AdminTB.Properties.Resources.Eraser;
            this.EraserPictBtn.Location = new System.Drawing.Point(556, 31);
            this.EraserPictBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EraserPictBtn.Name = "EraserPictBtn";
            this.EraserPictBtn.Size = new System.Drawing.Size(35, 37);
            this.EraserPictBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EraserPictBtn.TabIndex = 8;
            this.EraserPictBtn.TabStop = false;
            this.EraserPictBtn.Click += new System.EventHandler(this.EraserPictBtn_Click);
            // 
            // UserLogIn
            // 
            this.UserLogIn.Image = global::AdminTB.Properties.Resources.LogIn;
            this.UserLogIn.Location = new System.Drawing.Point(9, 10);
            this.UserLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserLogIn.Name = "UserLogIn";
            this.UserLogIn.Size = new System.Drawing.Size(74, 80);
            this.UserLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserLogIn.TabIndex = 0;
            this.UserLogIn.TabStop = false;
            // 
            // VisiblePassword
            // 
            this.VisiblePassword.Image = global::AdminTB.Properties.Resources.Visible;
            this.VisiblePassword.Location = new System.Drawing.Point(466, 188);
            this.VisiblePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VisiblePassword.Name = "VisiblePassword";
            this.VisiblePassword.Size = new System.Drawing.Size(30, 31);
            this.VisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VisiblePassword.TabIndex = 9;
            this.VisiblePassword.TabStop = false;
            this.VisiblePassword.Click += new System.EventHandler(this.VisiblePassword_Click);
            // 
            // UnvisiblePassword
            // 
            this.UnvisiblePassword.Image = global::AdminTB.Properties.Resources.Unvisible;
            this.UnvisiblePassword.Location = new System.Drawing.Point(466, 188);
            this.UnvisiblePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnvisiblePassword.Name = "UnvisiblePassword";
            this.UnvisiblePassword.Size = new System.Drawing.Size(30, 31);
            this.UnvisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UnvisiblePassword.TabIndex = 10;
            this.UnvisiblePassword.TabStop = false;
            this.UnvisiblePassword.Click += new System.EventHandler(this.UnvisiblePassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.EraserPictBtn);
            this.Controls.Add(this.RegistrationUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LogInTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.UserLogIn);
            this.Controls.Add(this.UnvisiblePassword);
            this.Controls.Add(this.VisiblePassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.EraserPictBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnvisiblePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserLogIn;
        private System.Windows.Forms.Label Authorization;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel RegistrationUser;
        private System.Windows.Forms.PictureBox EraserPictBtn;
        private System.Windows.Forms.PictureBox VisiblePassword;
        private System.Windows.Forms.PictureBox UnvisiblePassword;
    }
}