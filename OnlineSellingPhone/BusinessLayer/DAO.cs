using DataLayer.EF;
using System.Data;
using System.Linq;
using System;
using DataLayer.Enities;

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
            bool isAccountExist;
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                isAccountExist = db.Accounts.Any(acc => acc.Account_Username == username.ToLower());
            }
            return isAccountExist;
        }

        public static string EmailOfAccount(string username)
        {
            string email = "";
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (IsExistAccount(username))
                {
                    var account = db.Accounts.FirstOrDefault(acc => acc.Account_Username == username.ToLower());

                    if(account != null)
                    {
                        email = account.Account_Email;
                    }
                }
            }
            return email;
        }
    }
}
