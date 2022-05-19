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
    public partial class ListServices : UserControl
    {
        DataBase dataBase = new DataBase();

        public ListServices()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(dataGridService);
        }

        private void CreateColumns()
        {
            dataGridService.Columns.Add("ADP_id", "ID");
            dataGridService.Columns.Add("nameOfServise", "Название");
            dataGridService.Columns.Add("descriptionOfServise", "Описание");
            dataGridService.Columns.Add("price", "Цена");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select * from additionalPayServise";

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