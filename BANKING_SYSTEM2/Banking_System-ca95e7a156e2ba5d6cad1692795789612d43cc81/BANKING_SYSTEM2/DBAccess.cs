using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BANKING_SYSTEM2
{
    class DBAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        private static string strConnString = @"Data Source=KRISHNA-PC\INFINITEDB;Initial Catalog=SB BANK;Integrated Security=True";



        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void closeConn()
        {
            connection.Close();
        }

        

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;


                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}







