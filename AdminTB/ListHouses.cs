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
    public partial class ListHouses : UserControl
    {
        DataBase dataBase = new DataBase();
        public ListHouses()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(DataGridHouses);
        }

        private void CreateColumns() 
        {
            DataGridHouses.Columns.Add("houseId", "№");
            DataGridHouses.Columns.Add("typeHouse", "Тип дома");
            DataGridHouses.Columns.Add("descriptionOfHouse", "Описание");
            DataGridHouses.Columns.Add("numOfRooms", "Кол-во комнат");
            DataGridHouses.Columns.Add("price", "Цена");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select house.houseId, typeOfHouse.typeHouse, typeOfHouse.descriptionOfHouse, typeOfHouse.numOfRooms,  typeOfHouse.price " +
                $"from house inner join typeOfHouse on house.typeId = typeOfHouse.typeId";

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