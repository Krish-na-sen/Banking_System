using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BANKING_SYSTEM2
{
    class CustomerDAO
    {
        RegistrationData regData = new RegistrationData();
        private DBAccess objDbAccess;
        Login_Page login = new Login_Page();
        public CustomerDAO()
        {
            objDbAccess = new DBAccess();
        }







        public int customerRegister()
        {
         
            SqlCommand insertCommand = new SqlCommand("insert into CUSTOMER_REGISTRATION1(CUSTOMER_NAME,DOB,AGE,GENDER,ADDRESS,PHONE_NO,ACCOUNT_TYPE,ACCOUNT_START_DATE,CITY,STATE,PINCODE,PASSWORD) values(@customerName,@dob,@age,@gender,@address,@phoneNo,@accountType,@accountStartDate,@city,@state,@pincode,@password)");

            insertCommand.Parameters.AddWithValue("@customerName", regData.CustomerName);
            insertCommand.Parameters.AddWithValue("@dob", regData.DOB);
            insertCommand.Parameters.AddWithValue("@age", regData.Age);
            insertCommand.Parameters.AddWithValue("@gender", regData.Gender);
            insertCommand.Parameters.AddWithValue("@address", regData.Address);
            insertCommand.Parameters.AddWithValue("@phoneNo", regData.PhoneNo); ;
            insertCommand.Parameters.AddWithValue("@accountType", regData.AccountType);
            insertCommand.Parameters.AddWithValue("@accountStartDate", regData.AccountStartDate);
            insertCommand.Parameters.AddWithValue("@city", regData.City);
            insertCommand.Parameters.AddWithValue("@state", regData.State);
            insertCommand.Parameters.AddWithValue("@pincode", regData.Pincode);
            insertCommand.Parameters.AddWithValue("@password", regData.Password);


            int  row=objDbAccess.executeQuery(insertCommand);
            return row;

        }






        public void customerLogin(string customerID, string customerName, string password)

        {
            DataTable dataTable = new DataTable();
            string query = "Select * from  CUSTOMER_REGISTRATION1 where CUSTOMER_ID='" +customerID + "' AND CUSTOMER_NAME ='" +
                customerName + "' AND PASSWORD ='" + password + "' ";


            objDbAccess.readDatathroughAdapter(query, dataTable);
        }










        public int customerUpdate(
            string newCustomerNameHome,string newDobHome , string newAgeHome ,string newGenderHome, string newAddressHome,string newPhoneNoHome , string newAccountTypeHome ,string newAccountStartDateHome ,
        string newCityHome ,
        string newStateHome ,
        string newPincodeHome ,
        string newPasswordHome )

        {
           
            string query = "update CUSTOMER_REGISTRATION1  SET CUSTOMER_NAME ='" + newCustomerNameHome + "',DOB = '" + newDobHome + "', AGE = '" + newAgeHome + "',  GENDER = '" + newGenderHome + "',ADDRESS = '" + newAddressHome + "', PHONE_NO = '" + newPhoneNoHome + "', ACCOUNT_TYPE = '" + newAccountTypeHome + "', ACCOUNT_START_DATE = '" + newAccountStartDateHome + "',CITY = '" + newCityHome + "',  STATE = '" + newStateHome + "',  PINCODE = '" + newPincodeHome + "',  PASSWORD = '" + newPasswordHome + "' where CUSTOMER_ID = '" + Login_Page.CustomerId + "' ";
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


            int row = objDbAccess.executeQuery(updateCommand);
            return row;


        }










        public int customerDelete()
        {
          
            string query = "DELETE from CUSTOMER_REGISTRATION1  where CUSTOMER_ID ='" + Login_Page.CustomerId + "'";
            SqlCommand deleteCommand = new SqlCommand(query);

           int row = objDbAccess.executeQuery(deleteCommand);
            return row;

        }








        public void adminLogin(string adminUsername,string adminPassword)
        {
            DataTable datatable = new DataTable();
          
            string query = "Select * from  ADMIN_CREDENTIALS where USERNAME='" + adminUsername + "' AND PASSWORD ='" + adminPassword + "'  ";

           objDbAccess.readDatathroughAdapter(query,datatable);

        }









        public void adminControl()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * from CUSTOMER_REGISTRATION1";

            objDbAccess.readDatathroughAdapter(query, dataTable);

        }






    }
}
