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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class ListContarcts : UserControl
    {
        DataBase dataBase = new DataBase();
        public ListContarcts()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(DataGridContracts);
        }

        private void CreateColumns()
        {
            DataGridContracts.Columns.Add("agreementNum", "№ договора");
            DataGridContracts.Columns.Add("touristId", "ID отдыхающего");
            DataGridContracts.Columns.Add("houseId", "№ дома");
            DataGridContracts.Columns.Add("ADP_id", "ID доп.услуги");
            DataGridContracts.Columns.Add("date", "Дата оформления");
            DataGridContracts.Columns.Add("dateEnd", "Дата окончания");
            DataGridContracts.Columns.Add("sumPay", "Сумма к оплате");
            DataGridContracts.Columns.Add("paymentMethod", "Способ оплаты");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4), record.GetString(5), record.GetInt32(6), record.GetString(7));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select agreementOfRentH.agreementNum, agreementOfRentH.touristId, agreementOfRentH.houseId, agreementOfRentH.ADP_id, agreementOfRentH.date, agreementOfRentH.dateEnd, , agreementOfRentH.paymentMethod from agreementOfRentH inner join AgreementADP on agreementOfRentH.agreementNum = AgreementADP.agreementNum additionalPayServise inner join AgreementADP on additionalPayServise.ADP_id = AgreementADP.ADP_id";

            SqlCommand command = new SqlCommand(queryShow, dataBase.GetConnection());

            dataBase.GetConnection();
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
    }
}
