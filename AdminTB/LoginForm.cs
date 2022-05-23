using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminTB
{
    public partial class LoginForm : Form
    {
        DataBase database = new DataBase();
        Hash hash = new Hash();

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

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = LogInTextBox.Text;
            var passwordUser = hash.GetHash(PasswordTextBox.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryAutorization = $"select id_user, login_user, password_user from auntification where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(queryAutorization, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.ShowDialog();

            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        Point LastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}