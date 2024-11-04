using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental
{
    internal class DBConnection
    {
        private static DBConnection _instance;

        private string connStr;

        private SqlConnection connToDB;

        private DBConnection()
        {
            connStr = Properties.Settings.Default.MemberDBConnection;

        }

        public static DBConnection getInstanceofDBConnectionStr()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        public DataSet GetDataSet(string sqlQuery)
        {
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                adapter.Fill(dataSet);
            }
            return dataSet;
        }
    }
}
