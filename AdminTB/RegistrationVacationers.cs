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
    public partial class RegistrationVacationers : UserControl
    {
        DataBase database = new DataBase();

        public RegistrationVacationers()
        {
            InitializeComponent();
        }

        private void AddVacationersButton_Click(object sender, EventArgs e)
        {
            var secondName = SurnameTextBox.Text;
            var firstName = FirstNameTextBox.Text;
            var phoneNum = PhoneTextBox.Text;
            var pasNum = NumberPassportTextBox.Text;
            var pasSeries = SeriesPassportTextBox.Text;

            string queryRegistration = $"insert into tourist(secondName, firstName, phoneNum, passportNum, passportSeries) values ('{secondName}', '{firstName}', '{phoneNum}', '{pasNum}', '{pasSeries}')";

            if (secondName != "" && firstName != "" && phoneNum != "" && pasNum != "" && pasSeries != "")
            {
                MessageBox.Show("Отдыхающий был успешно зарегестрирован!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand command = new SqlCommand(queryRegistration, database.GetConnection());

                database.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            else
            {
                MessageBox.Show("Отдыхающий не был зарегистрирован!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SurnameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            PhoneTextBox.Text = "";
            NumberPassportTextBox.Text = "";
            SeriesPassportTextBox.Text = "";
        }
    }
}