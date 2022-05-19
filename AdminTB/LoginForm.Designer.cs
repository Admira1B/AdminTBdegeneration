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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.Authorization.Location = new System.Drawing.Point(125, 38);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(272, 46);
            this.Authorization.TabIndex = 1;
            this.Authorization.Text = "Авторизация";
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInLabel.Location = new System.Drawing.Point(165, 171);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(101, 32);
            this.LogInLabel.TabIndex = 2;
            this.LogInLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(147, 231);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(121, 32);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LogInTextBox.Location = new System.Drawing.Point(273, 167);
            this.LogInTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInTextBox.MaxLength = 50;
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(343, 38);
            this.LogInTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.PasswordTextBox.Location = new System.Drawing.Point(273, 231);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(343, 38);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button1.Location = new System.Drawing.Point(344, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 63);
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
            this.RegistrationUser.Location = new System.Drawing.Point(333, 391);
            this.RegistrationUser.Name = "RegistrationUser";
            this.RegistrationUser.Size = new System.Drawing.Size(170, 22);
            this.RegistrationUser.TabIndex = 7;
            this.RegistrationUser.TabStop = true;
            this.RegistrationUser.Text = "Ещё нет аккаунта?";
            this.RegistrationUser.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegistrationUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationUser_LinkClicked);
            // 
            // EraserPictBtn
            // 
            this.EraserPictBtn.Image = global::AdminTB.Properties.Resources.Eraser;
            this.EraserPictBtn.Location = new System.Drawing.Point(741, 38);
            this.EraserPictBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EraserPictBtn.Name = "EraserPictBtn";
            this.EraserPictBtn.Size = new System.Drawing.Size(47, 46);
            this.EraserPictBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EraserPictBtn.TabIndex = 8;
            this.EraserPictBtn.TabStop = false;
            this.EraserPictBtn.Click += new System.EventHandler(this.EraserPictBtn_Click);
            // 
            // UserLogIn
            // 
            this.UserLogIn.Image = global::AdminTB.Properties.Resources.LogIn;
            this.UserLogIn.Location = new System.Drawing.Point(12, 12);
            this.UserLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserLogIn.Name = "UserLogIn";
            this.UserLogIn.Size = new System.Drawing.Size(99, 98);
            this.UserLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserLogIn.TabIndex = 0;
            this.UserLogIn.TabStop = false;
            // 
            // VisiblePassword
            // 
            this.VisiblePassword.Image = global::AdminTB.Properties.Resources.Visible;
            this.VisiblePassword.Location = new System.Drawing.Point(621, 231);
            this.VisiblePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisiblePassword.Name = "VisiblePassword";
            this.VisiblePassword.Size = new System.Drawing.Size(40, 38);
            this.VisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VisiblePassword.TabIndex = 9;
            this.VisiblePassword.TabStop = false;
            this.VisiblePassword.Click += new System.EventHandler(this.VisiblePassword_Click);
            // 
            // UnvisiblePassword
            // 
            this.UnvisiblePassword.Image = global::AdminTB.Properties.Resources.Unvisible;
            this.UnvisiblePassword.Location = new System.Drawing.Point(621, 231);
            this.UnvisiblePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnvisiblePassword.Name = "UnvisiblePassword";
            this.UnvisiblePassword.Size = new System.Drawing.Size(40, 38);
            this.UnvisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UnvisiblePassword.TabIndex = 10;
            this.UnvisiblePassword.TabStop = false;
            this.UnvisiblePassword.Click += new System.EventHandler(this.UnvisiblePassword_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(766, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 32);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "AdminTB (Авторизация)";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}