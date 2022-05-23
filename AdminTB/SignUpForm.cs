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
    public partial class SignUpForm : Form
    {
        DataBase database = new DataBase();

        public SignUpForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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

        private void NewAccount_Click(object sender, EventArgs e)
        {
            var login = LogInTextBox.Text;
            var password = PasswordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            if ((login != "" && password != "") && Checkuser())
            {
                string queryRegistration = $"insert into auntification(login_user, password_user) values('{login}','{password}')";
                SqlCommand command = new SqlCommand(queryRegistration, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                MessageBox.Show("Вы были успешно зарегестрированы!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Аккаунт не создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean Checkuser()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            var login_user = LogInTextBox.Text;

            string queryCheck = $"select login_user from auntification where login_user = '{login_user}'";
            SqlCommand commandCheck = new SqlCommand(queryCheck, database.GetConnection());

            adapter.SelectCommand = commandCheck;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CloseButtonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void SignUpForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void SignUpForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm frm_log = new LoginForm();
            frm_log.Show();
            this.Hide();
        }
    }
}