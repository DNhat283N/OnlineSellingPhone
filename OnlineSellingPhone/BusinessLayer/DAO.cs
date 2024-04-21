using DataLayer.EF;
using System.Data;
using System.Linq;
using System;
using DataLayer.Enities;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class DAO
    {
        public static DataTable GetCustomerByNameKeyword(string kw)
        {
            DataTable customers = new DataTable();

            if (kw != "")
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    var query = from cus in db.Customers
                                select (cus);
                    customers = (DataTable)query;
                }
            }
            else
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    var query = from cus in db.Customers
                                where cus.Customer_FName.Contains(kw)
                                select (cus);
                    customers = (DataTable)query;
                }
            }

            return customers;
        }

        //Sign Up form 
        public static void InsertCustomer(string fname, DateTime birthday, bool gender)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                Customer customer = new Customer(fname, gender, birthday);
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void InsertAccount(int customer_Id, string username, string password, string email)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                Account account = new Account(username.ToLower(), password, email.ToLower(), customer_Id);
            }
        }

        public static void AddSignUpCustomerInformation(string fname, bool gender, DateTime birthday, string username, string password, string email, string phoneNumber)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                Customer customer = new Customer(fname, gender, birthday);
                db.Customers.Add(customer);
                db.SaveChanges();

                int customer_Id = customer.Customer_ID;

                db.Accounts.Add(new Account(username.ToLower(), password, email.ToLower(), customer_Id));
                db.SaveChanges();

                db.PhoneNumbers.Add(new PhoneNumber(phoneNumber, customer_Id));
                db.SaveChanges();
            }
        }

        public static bool IsExistAccount(string username)
        {
            bool isAccountExist = false;
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                isAccountExist = db.Accounts.Any(acc => acc.Account_Username == username.ToLower());
            }
            return isAccountExist;
        }

        public static bool IsExistEmail(string email)
        {
            bool isEmailExist = false;
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                isEmailExist = db.Accounts.Any(acc => acc.Account_Email == email.ToLower());
            }
            return isEmailExist;
        }

        //Forgot password form 

        public static bool ResetAccountPassword(string username, string password)
        {
            bool isReseted = false;
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (IsExistAccount(username))
                {
                    var account = db.Accounts.FirstOrDefault(acc => acc.Account_Username == username.ToLower());
                    account.Account_Password = password;
                    isReseted = true;
                }
                else
                {
                    isReseted = false;
                }
            }
            return isReseted;
        }

        public static string EmailOfAccount(string username)
        {
            string email = "";
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (IsExistAccount(username))
                {
                    var account = db.Accounts.FirstOrDefault(acc => acc.Account_Username == username.ToLower());

                    if (account != null)
                    {
                        email = account.Account_Email;
                    }
                }
            }
            return email;
        }

        //Sign In Form

        public static bool AuthenticateAccountLogin(string username, string password)
        {
            bool isAuthenticated = false;
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (IsExistAccount(username))
                {
                    isAuthenticated = db.Accounts.Any(acc => acc.Account_Username == username.ToLower() && acc.Account_Password == password);
                    isAuthenticated = true;
                }
                else
                {
                    isAuthenticated = false;
                }
            }
            return isAuthenticated;
        }

        //Query 

        public static List<Phone> QueryPhoneInformationByManufacturerName(string name)
        {
            List<Phone> data = new List<Phone>();
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (db.Manufacturers.Any(m => m.Manufacturer_Name.ToLower() == name.ToLower()))
                {
                    var query = from p in db.Phones
                                join m in db.Manufacturers on p.Manufacturer_ID equals m.Manufacturer_ID
                                where m.Manufacturer_Name.ToLower() == name.ToLower()
                                select p;
                    data = query.ToList();
                }
            }
            return data;
        }


        public static List<Phone> QueryAllPhoneTable()
        {
            List<Phone> data = new List<Phone>();
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                var query = from p in db.Phones
                            select p;
                data = query.ToList();
            }
            return data;
        }
    }
}
