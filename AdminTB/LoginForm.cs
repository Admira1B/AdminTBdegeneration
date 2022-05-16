﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminTB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm frm_sign = new SignUpForm();
            frm_sign.Show();
            this.Hide();
        }

        private void EraserPictBtn_Click(object sender, EventArgs e)
        {
            LogInTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void VisiblePassword_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            VisiblePassword.Visible = false;
            UnvisiblePassword.Visible = true;
        }

        private void UnvisiblePassword_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
            VisiblePassword.Visible = true;
            UnvisiblePassword.Visible = false;
        }
    }
}