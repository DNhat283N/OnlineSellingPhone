using DataLayer.EF;
using System.Data;
using System.Linq;
using System;
using DataLayer.Enities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DAO
    {

        public enum PRICE_FILTER
        {
            ASCENDING,
            DESCENDING,
            NONE
        }

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

                db.Accounts.Add(new Account(username.ToLower(), password, email.ToLower(), customer.Customer_ID));

                db.PhoneNumbers.Add(new PhoneNumber(phoneNumber, customer.Customer_ID));
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
                    db.SaveChanges();
                    isReseted = true;
                    db.SaveChanges();
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

        private static List<Phone> QueryPhoneInformationByManufacturerName(List<Phone> phones, string name = "")
        {
            List<Phone> resultPhonesList = new List<Phone>(phones);
            if(name != "")
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    if (db.Manufacturers.Any(m => m.Manufacturer_Name.ToLower() == name.ToLower()))
                    {
                        var query = from p in resultPhonesList
                                    join m in db.Manufacturers on p.Manufacturer_ID equals m.Manufacturer_ID
                                    where m.Manufacturer_Name.ToLower() == name.ToLower()
                                    select p;
                        resultPhonesList = query.ToList();
                    }
                }
            }
            return resultPhonesList;
        }

        private static List<Phone> SortPhoneList(List<Phone> phones, PRICE_FILTER sort = PRICE_FILTER.NONE)
        {
            List<Phone> sortedPhoneList = new List<Phone>(phones);
            if(sort == PRICE_FILTER.ASCENDING)
            {
                sortedPhoneList.Sort((x, y) => x.Phone_Price.CompareTo(y.Phone_Price));
                return sortedPhoneList;
            } 
            else if(sort == PRICE_FILTER.DESCENDING)
            {
                sortedPhoneList.Sort((x, y) => y.Phone_Price.CompareTo(x.Phone_Price));
                return sortedPhoneList;
            }
            else
                return phones;
        }

        private static List<Phone> SearchPhone(string keyword = "")
        {
            List<Phone> phoneList = new List<Phone>();
            if(keyword == "")
            {
                phoneList = QueryAllPhoneTable();
            }
            else
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    var query = from p in db.Phones
                            where p.Phone_Name.ToLower().Contains(keyword.ToLower())
                            select p;
                    phoneList = query.ToList();
                }
            }
            return phoneList;
        }

        public static List<Phone> QueryPhoneTableBySearchKeywordOrByManuFacturerNameAndFilterByPrice(string keyword = "", string manufacturerName = "", PRICE_FILTER priceFilter = PRICE_FILTER.NONE)
        {
            List<Phone> resultListPhone = new List<Phone>();
            resultListPhone = SearchPhone(keyword);
            resultListPhone = QueryPhoneInformationByManufacturerName(resultListPhone, manufacturerName);
            resultListPhone = SortPhoneList(resultListPhone, priceFilter);
            return resultListPhone;
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

        //Admin

        private static bool AddImage(string[] imageURLs, int phoneID)
        {
            bool isImageAdded = false;
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (db.Phones.Count(p => p.Phone_ID == phoneID) != 1)
                {
                    return isImageAdded = false;
                }

                int countImagesOfPhone = db.Images.Count(i => i.Phone_ID == phoneID);
                if (countImagesOfPhone >= 0 || countImagesOfPhone < 2)
                {
                    foreach (string url in imageURLs)
                    {
                        db.Images.Add(new Image(url, phoneID));
                    }
                    isImageAdded = true;
                }
                else
                {
                    return isImageAdded = false;
                }

            }
            return isImageAdded;
        }


        public static bool AddPhone(string phoneName, string phoneColor, double phonePrice, int phoneReadyInStock, int phoneManufacturerID, string [] phoneImageURLs)
        {
            bool isAdded = false;
            if (phoneImageURLs.Length > 2)
            {
                Console.WriteLine("Error Of Array Length!");
                return isAdded;
            }
            try
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    Phone phone = new Phone(phoneName, phoneColor, phonePrice, phoneReadyInStock, phoneManufacturerID);
                    db.Phones.Add(phone);                   
                    if (AddImage(phoneImageURLs, phone.Phone_ID)){
                        db.SaveChanges();
                        isAdded = true;
                    }
                }
            }
            catch
            {
                isAdded = false;
            }
            return isAdded;
        }
    }
}
