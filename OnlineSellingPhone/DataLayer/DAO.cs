using DataLayer.EF;
using System.Data;
using System.Linq;
using System;
using DataLayer.Enities;

namespace DataLayer
{
    public class DAO
    {
        public DataTable getCustomerByNameKeyword(string kw)
        {
            DataTable customers = new DataTable();

            if(kw != "")
            {
                using(OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
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

        public void insertCustomer(string fname, DateTime birthday, bool gender)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                Customer customer = new Customer(fname, gender, birthday);
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public void insertAccount(int customer_id, string username, string password)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                Account account = new Account(username, password, customer_id);
            }
        }
    }
}
