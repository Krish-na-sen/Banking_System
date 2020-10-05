using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DALayer
{
    public class DBLayer
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



        public DataTable readDatathroughAdapter(string query)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                DataTable dt = new DataTable();


                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
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



        public DataTable ExecuteSqlString(string sqlstring)
        {
          try {
                if (connection.State == 0)
                {
                    createConn();
                }
                DataTable dt = new DataTable();
                SqlCommand objcmd = new SqlCommand(sqlstring, connection);
                SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                objAdp.Fill(dt);
                return dt;
             }
            catch(Exception ex)
            {
                throw ex;
            }
       }






        public int customerRegister(string customerName, string dob, string age, 
            string gender, string address, string phoneNo, string accountType,
            string accountStartDate, string city, string state, string pincode, string password)
        
        {

            SqlCommand insertCommand = new SqlCommand("insert into CUSTOMER_REGISTRATION1(CUSTOMER_NAME,DOB,AGE,GENDER,ADDRESS,PHONE_NO,ACCOUNT_TYPE,ACCOUNT_START_DATE,CITY,STATE,PINCODE,PASSWORD) values(@customerName,@dob,@age,@gender,@address,@phoneNo,@accountType,@accountStartDate,@city,@state,@pincode,@password)");

            insertCommand.Parameters.AddWithValue("@customerName", customerName);
            insertCommand.Parameters.AddWithValue("@dob", dob);
            insertCommand.Parameters.AddWithValue("@age", age);
            insertCommand.Parameters.AddWithValue("@gender", gender);
            insertCommand.Parameters.AddWithValue("@address", address);
            insertCommand.Parameters.AddWithValue("@phoneNo", phoneNo); ;
            insertCommand.Parameters.AddWithValue("@accountType", accountType);
            insertCommand.Parameters.AddWithValue("@accountStartDate", accountStartDate);
            insertCommand.Parameters.AddWithValue("@city", city);
            insertCommand.Parameters.AddWithValue("@state", state);
            insertCommand.Parameters.AddWithValue("@pincode", pincode);
            insertCommand.Parameters.AddWithValue("@password", password);



            int row = executeQuery(insertCommand);
            return row;

        }


        public DataTable customerLogin(string CustomerId,string CustomerName,string Password)

        {

            DataTable dtCustomer = new DataTable();
            string query = "Select * from  CUSTOMER_REGISTRATION1 where CUSTOMER_ID='" + CustomerId + "' AND CUSTOMER_NAME ='" +CustomerName + "' AND PASSWORD ='" +Password + "' ";



            dtCustomer = readDatathroughAdapter(query);
            return dtCustomer;
        }





       public int customerUpdate(string newCustomerNameHome ,string newDobHome, string newAgeHome , string newGenderHome, string newAddressHome , string newPhoneNoHome , string newAccountTypeHome, string newAccountStartDateHome ,string newCityHome, string newStateHome , string newPincodeHome , string newPasswordHome , int CustomerId) 
        

        {

            string query = "update CUSTOMER_REGISTRATION1  SET CUSTOMER_NAME ='" + newCustomerNameHome + "',DOB = '" + newDobHome + "', AGE = '" +newAgeHome + "',  GENDER = '" +newGenderHome + "',ADDRESS = '" +newAddressHome + "', PHONE_NO = '" + newPhoneNoHome + "', ACCOUNT_TYPE = '" +newAccountTypeHome + "', ACCOUNT_START_DATE = '" + newAccountStartDateHome + "',CITY = '" + newCityHome + "',  STATE = '" + newStateHome + "',  PINCODE = '" +newPincodeHome + "',  PASSWORD = '" + newPasswordHome + " '   WHERE CUSTOMER_ID = '" +CustomerId + "' ";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@newCustomerNameHome", newCustomerNameHome);
            updateCommand.Parameters.AddWithValue("@newDobHome", newDobHome);
            updateCommand.Parameters.AddWithValue("newAgeHome", newAgeHome);
            updateCommand.Parameters.AddWithValue("newGenderHome", newGenderHome);
            updateCommand.Parameters.AddWithValue("@newAddressHome", newAddressHome);
            updateCommand.Parameters.AddWithValue("@newPhoneNoHome", newPhoneNoHome); ;
            updateCommand.Parameters.AddWithValue("@newAccountTypeHome", newAccountTypeHome);
            updateCommand.Parameters.AddWithValue("@newAccountStartDateHome", newAccountStartDateHome);
            updateCommand.Parameters.AddWithValue("@newCityHome", newCityHome);
            updateCommand.Parameters.AddWithValue("@newStateHome", newStateHome);
            updateCommand.Parameters.AddWithValue("@newPincodeHome", newPincodeHome);
            updateCommand.Parameters.AddWithValue("@newPasswordHome", newPasswordHome);



            int row = executeQuery(updateCommand);
            return row;


        }










        public int customerDelete(int CustomerId)
        {

            string query = "DELETE from CUSTOMER_REGISTRATION1  where CUSTOMER_ID ='" + CustomerId + "'";
            SqlCommand deleteCommand = new SqlCommand(query);

            int row =executeQuery(deleteCommand);
            return row;

        }








        public DataTable adminLogin(string adminUsername,string adminPassword )
        {
            DataTable dtAdmin = new DataTable();

            string query = "Select * from  ADMIN_CREDENTIALS where USERNAME='" + adminUsername + "' AND PASSWORD ='" + adminPassword + "'  ";

            dtAdmin=readDatathroughAdapter(query);
            return dtAdmin;
        }









        public DataTable adminControl()
        {
            DataTable tbCustomer = new DataTable();
            string query = "SELECT * from CUSTOMER_REGISTRATION1";
            tbCustomer=readDatathroughAdapter(query);
            return tbCustomer;
        }








    }
}

    

