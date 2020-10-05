using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DALayer;



namespace BusinessLayer
{
    public class BALayer
    {
        public DBLayer objDBL = new DBLayer();




        public int customerRegisterBA(string customerName, string dob, string age,
            string gender, string address, string phoneNo, string accountType,
            string accountStartDate, string city, string state, string pincode, string password)
        {
            int row = objDBL.customerRegister(customerName, dob, age, gender, address, phoneNo, accountType, accountStartDate, city, state, pincode, password);
            return row;

        }






        public DataTable customerLoginBA(string CustomerId, string CustomerName, string Password)

        {

            DataTable dtCustomerBA = objDBL.customerLogin(CustomerId, CustomerName, Password); ;
            return dtCustomerBA;
          }







        public int customerUpdateBA(string newCustomerNameHome, string newDobHome, string newAgeHome, string newGenderHome, string newAddressHome, string newPhoneNoHome, string newAccountTypeHome, string newAccountStartDateHome, string newCityHome, string newStateHome, string newPincodeHome, string newPasswordHome, int CustomerId)

        {
            int row = objDBL.customerUpdate(newCustomerNameHome, newDobHome, newAgeHome, newGenderHome, newAddressHome, newPhoneNoHome, newAccountTypeHome, newAccountStartDateHome, newCityHome, newStateHome, newPincodeHome, newPasswordHome, CustomerId);
            return row;
        }



    




        public int customerDeleteBA(int CustomerId)

        {
            int row = objDBL.customerDelete(CustomerId);
            return row;
        }





        public DataTable adminLoginBA(string adminUsername, string adminPassword)
        {
            DataTable dtAdminBA = objDBL.adminLogin(adminUsername, adminPassword);
            return dtAdminBA;

        }




        public DataTable adminControlBA()

        {
            DataTable tbcustomerBA = objDBL.adminControl();
            return tbcustomerBA;
        }

        }
    }
