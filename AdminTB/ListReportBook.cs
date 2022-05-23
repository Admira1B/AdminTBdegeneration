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
    public partial class ListReportBook : UserControl
    {
        DataBase dataBase = new DataBase();

        public ListReportBook()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(ReportBookDataGrid);
        }

        private void CreateColumns()
        {
            ReportBookDataGrid.Columns.Add("numReport", "№");
            ReportBookDataGrid.Columns.Add("secondName", "Фамилия подавшего");
            ReportBookDataGrid.Columns.Add("firstName", "Имя подавшего");
            ReportBookDataGrid.Columns.Add("descriptionRep", "Содержание");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select reportBook.numReport, tourist.secondName ,tourist.firstName, reportBook.descriptionRep from reportBook inner join tourist on tourist.touristId = reportBook.touristId";

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
