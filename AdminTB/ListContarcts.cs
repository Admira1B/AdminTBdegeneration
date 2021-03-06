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
            DataGridContracts.Columns.Add("term", "Кол-во дней");
            DataGridContracts.Columns.Add("sumPay", "Сумма к оплате");
            DataGridContracts.Columns.Add("paymentMethod", "Способ оплаты");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetString(6));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select " +
                $"agreementOfRentH.agreementNum, " +
                $"agreementOfRentH.touristId, " +
                $"agreementOfRentH.houseId, " +
                $"AdditionalPayServise.ADP_id, " +
                $"agreementOfRentH.term, " +
                $"(additionalPayServise.price + typeOfHouse.price) * agreementOfRentH.term," +
                $"agreementOfRentH.paymentMethod " +
                $"from agreementOfRentH " +
                $"inner join AdditionalPayServise on agreementOfRentH.ADP_id = AdditionalPayServise.ADP_id " +
                $"inner join House on House.houseId = agreementOfRentH.houseId " +
                $"inner join TypeOfHouse on TypeOfHouse.typeId = House.typeId ";

            
           
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