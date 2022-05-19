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
    public partial class ListVacationers : UserControl
    {
        DataBase dataBase = new DataBase();

        public ListVacationers()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(DataGridVacationers);
        }

        private void CreateColumns() 
        {
            DataGridVacationers.Columns.Add("touristId", "ID");
            DataGridVacationers.Columns.Add("secondName", "Фамилия");
            DataGridVacationers.Columns.Add("firstName", "Имя");
            DataGridVacationers.Columns.Add("phoneNum", "Номер телефона");
            DataGridVacationers.Columns.Add("passportNum", "Номер паспорта");
            DataGridVacationers.Columns.Add("passportSeries", "Серия паспорта");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select * from tourist";

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
