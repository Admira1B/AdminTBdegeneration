namespace AdminTB
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.NewAccount = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.UserSignUp = new System.Windows.Forms.PictureBox();
            this.EraserPictBtn = new System.Windows.Forms.PictureBox();
            this.VisiblePassword = new System.Windows.Forms.PictureBox();
            this.UnvisiblePassword = new System.Windows.Forms.PictureBox();
            this.CloseButtonLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UserSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserPictBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnvisiblePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // NewAccount
            // 
            this.NewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.NewAccount.Location = new System.Drawing.Point(344, 306);
            this.NewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(155, 63);
            this.NewAccount.TabIndex = 13;
            this.NewAccount.Text = "Создать";
            this.NewAccount.UseVisualStyleBackColor = true;
            this.NewAccount.Click += new System.EventHandler(this.NewAccount_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.PasswordTextBox.Location = new System.Drawing.Point(273, 231);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(343, 38);
            this.PasswordTextBox.TabIndex = 12;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LogInTextBox.Location = new System.Drawing.Point(273, 167);
            this.LogInTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(343, 38);
            this.LogInTextBox.TabIndex = 11;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(147, 231);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(121, 32);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInLabel.Location = new System.Drawing.Point(165, 171);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(101, 32);
            this.LogInLabel.TabIndex = 9;
            this.LogInLabel.Text = "Логин:";
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(125, 38);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(270, 46);
            this.Registration.TabIndex = 8;
            this.Registration.Text = "Регистрация";
            // 
            // UserSignUp
            // 
            this.UserSignUp.Image = global::AdminTB.Properties.Resources.SignUp;
            this.UserSignUp.Location = new System.Drawing.Point(12, 12);
            this.UserSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserSignUp.Name = "UserSignUp";
            this.UserSignUp.Size = new System.Drawing.Size(99, 98);
            this.UserSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserSignUp.TabIndex = 7;
            this.UserSignUp.TabStop = false;
            // 
            // EraserPictBtn
            // 
            this.EraserPictBtn.Image = global::AdminTB.Properties.Resources.Eraser;
            this.EraserPictBtn.Location = new System.Drawing.Point(741, 38);
            this.EraserPictBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EraserPictBtn.Name = "EraserPictBtn";
            this.EraserPictBtn.Size = new System.Drawing.Size(47, 46);
            this.EraserPictBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EraserPictBtn.TabIndex = 14;
            this.EraserPictBtn.TabStop = false;
            this.EraserPictBtn.Click += new System.EventHandler(this.EraserPictBtn_Click);
            // 
            // VisiblePassword
            // 
            this.VisiblePassword.Image = global::AdminTB.Properties.Resources.Visible;
            this.VisiblePassword.Location = new System.Drawing.Point(621, 231);
            this.VisiblePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisiblePassword.Name = "VisiblePassword";
            this.VisiblePassword.Size = new System.Drawing.Size(40, 38);
            this.VisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VisiblePassword.TabIndex = 15;
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
            this.UnvisiblePassword.TabIndex = 16;
            this.UnvisiblePassword.TabStop = false;
            this.UnvisiblePassword.Click += new System.EventHandler(this.UnvisiblePassword_Click);
            // 
            // CloseButtonLinkLabel
            // 
            this.CloseButtonLinkLabel.AutoSize = true;
            this.CloseButtonLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButtonLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.CloseButtonLinkLabel.Location = new System.Drawing.Point(766, 0);
            this.CloseButtonLinkLabel.Name = "CloseButtonLinkLabel";
            this.CloseButtonLinkLabel.Size = new System.Drawing.Size(31, 29);
            this.CloseButtonLinkLabel.TabIndex = 17;
            this.CloseButtonLinkLabel.TabStop = true;
            this.CloseButtonLinkLabel.Text = "X";
            this.CloseButtonLinkLabel.VisitedLinkColor = System.Drawing.Color.Red;
            this.CloseButtonLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseButtonLinkLabel_LinkClicked);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButtonLinkLabel);
            this.Controls.Add(this.UnvisiblePassword);
            this.Controls.Add(this.EraserPictBtn);
            this.Controls.Add(this.NewAccount);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LogInTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.UserSignUp);
            this.Controls.Add(this.VisiblePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUpForm";
            this.Text = "AdminTB (Регистрация)";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignUpForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SignUpForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.UserSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserPictBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnvisiblePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAccount;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.PictureBox UserSignUp;
        private System.Windows.Forms.PictureBox EraserPictBtn;
        private System.Windows.Forms.PictureBox VisiblePassword;
        private System.Windows.Forms.PictureBox UnvisiblePassword;
        private System.Windows.Forms.LinkLabel CloseButtonLinkLabel;
    }
}