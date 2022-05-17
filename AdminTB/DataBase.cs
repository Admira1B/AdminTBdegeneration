using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdminTB
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=10.0.22.5;Initial Catalog=ARM_TB;Persist Security Info=True;User ID=ARM_TB;Password=1234ABCd");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
