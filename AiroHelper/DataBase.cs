using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiroHelper
{
    internal class DataBase
    {
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=gogs.wsr.ru;Initial Catalog=AiroHelper;User ID=731-20;Password=oU8fFUHH");
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PD7QD52;Initial Catalog=AiroHelper;Integrated Security=True;");
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
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
