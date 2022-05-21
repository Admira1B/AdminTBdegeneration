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
    public partial class ListExcursions : UserControl
    {
        DataBase dataBase = new DataBase();

        public ListExcursions()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(DataGridExcursions);
        }

        private void CreateColumns()
        {
            DataGridExcursions.Columns.Add("excursionId", "№");
            DataGridExcursions.Columns.Add("[content]", "Описание");
            DataGridExcursions.Columns.Add("price", "Стоимость");
            DataGridExcursions.Columns.Add("place", "Место проведения");
            DataGridExcursions.Columns.Add("secondName", "Экскурсовод");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select Excursion.excursionId, Excursion.[content], Excursion.price, Excursion.place, Employee.secondName from Excursion inner join Employee on Employee.employeeId = Excursion.employeeId";

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
