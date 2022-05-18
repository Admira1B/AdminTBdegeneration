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

            string queryRegistration = $"insert into auntification(login_user, password_user) values('{login}','{password}')";

            SqlCommand command = new SqlCommand(queryRegistration, database.GetConnection());

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
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

        private Boolean checkuser()
        {
            var loginUser = LogInTextBox.Text;
            var passUser = PasswordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryCheck = $"select * from auntification where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(queryCheck, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}