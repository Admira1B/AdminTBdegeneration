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
    public partial class RegistrationContracts : UserControl
    {
        DataBase database = new DataBase();

        public RegistrationContracts()
        {
            InitializeComponent();
        }

        private void AddContractsButton_Click(object sender, EventArgs e)
        {
            var vacationerId = IdVacationerTextBox.Text;
            var houseNum = NumberHouseTextBox.Text;
            var idService = CodeServicesTextBox.Text;
            var payment = PaymentMethodTextBox.Text;
            var term = TermTextBox.Text;

            string queryRegistration = $"insert into agreementOfRentH(touristId, houseId, ADP_id, term, paymentMethod) values ('{vacationerId}', '{houseNum}', '{idService}', '{term}', '{payment}')";

            if (vacationerId != "" && houseNum != "" && idService != "" && payment != "" && payment != "")
            {
                MessageBox.Show("Договор был успешно оформлен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand command = new SqlCommand(queryRegistration, database.GetConnection());

                database.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            else
            {
                MessageBox.Show("Договор не был оформлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            IdVacationerTextBox.Text = "";
            NumberHouseTextBox.Text = "";
            CodeServicesTextBox.Text = "";
            PaymentMethodTextBox.Text = "";
            TermTextBox.Text = "";
        }
    }
}
