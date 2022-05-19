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
    public partial class ListEmployees : UserControl
    {
        DataBase dataBase = new DataBase();

        public ListEmployees()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(DataGridVacationers);
        }

        private void CreateColumns()
        {
            DataGridVacationers.Columns.Add("employeeId", "ID");
            DataGridVacationers.Columns.Add("jobTtitle", "Должность");
            DataGridVacationers.Columns.Add("secondName", "Фамилия");
            DataGridVacationers.Columns.Add("firtstName", "Имя");
            DataGridVacationers.Columns.Add("phoneNum", "Телефон");
            DataGridVacationers.Columns.Add("eMail", "e-mail");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryShow = $"select employee.employeeId, post.jobTtile, employee.secondName, employee.firstName, employee.phoneNum, employee.eMail from employee inner join post on post.postId = employee.postId";

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