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

        private static bool AuthenticateAccountLogin(string username, string password)
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

        public static int AuthenticateAndAuthorizeAccountLogin(string username, string password)
        {
            int role = -1;
            if (AuthenticateAccountLogin(username, password))
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    var query = from acc in db.Accounts
                                where (acc.Account_Username == username.ToLower() && acc.Account_Password == password)
                                select acc.Account_UserRoleEnum;
                    UserRoleEnum userRole = query.FirstOrDefault();
                    if (userRole == UserRoleEnum.ADMIN)
                    {
                        role = 0;
                    }
                    else if (userRole == UserRoleEnum.CUSTOMER)
                        role = 1;
                }
            }
            else role = -1;
            return role;
        }

        //Query 

        private static List<Phone> QueryPhoneInformationByManufacturerName(List<Phone> phones, string name = "")
        {
            List<Phone> resultPhonesList = new List<Phone>(phones);
            if (name != "")
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
            if (sort == PRICE_FILTER.ASCENDING)
            {
                sortedPhoneList.Sort((x, y) => x.Phone_Price.CompareTo(y.Phone_Price));
                return sortedPhoneList;
            }
            else if (sort == PRICE_FILTER.DESCENDING)
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
            if (keyword == "")
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

        private static List<Phone> ShowInactivatingPhone(List<Phone> phones, bool isShowInactivatingPhone)
        {
            List<Phone> phoneList = new List<Phone>(phones);
            if (!isShowInactivatingPhone)
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    var query = from p in db.Phones
                                where p.Phone_Active.Equals(true)
                                select p;
                    phoneList = query.ToList();
                }
                return phoneList;
            }
            else return phoneList;
        }

        public static List<Phone> QueryPhoneTableBySearchKeywordOrByManuFacturerNameAndFilterByPrice(string keyword = "", string manufacturerName = "", PRICE_FILTER priceFilter = PRICE_FILTER.NONE, bool isShowInactivatedPhone = false)
        {
            List<Phone> resultListPhone = new List<Phone>();
            resultListPhone = SearchPhone(keyword);
            resultListPhone = QueryPhoneInformationByManufacturerName(resultListPhone, manufacturerName);
            resultListPhone = SortPhoneList(resultListPhone, priceFilter);
            resultListPhone = ShowInactivatingPhone(resultListPhone, isShowInactivatedPhone);
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

        public static Phone QueryPhoneByID(int phoneID)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                var query = from p in db.Phones
                            join c in db.Configurations on p.Configuration_ID equals c.Configuration_ID
                            where p.Phone_ID.Equals(phoneID)
                            select p;
                return query.FirstOrDefault();
            }
        }

        public static List<Image> QueryImagesOfPhoneByPhoneID(int phoneID)
        {
            List<Image> list = new List<Image>();
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                var query = from i in db.Images
                            join p in db.Phones on i.Phone_ID equals p.Phone_ID
                            where i.Phone_ID.Equals(phoneID)
                            select i;
                list = query.ToList();
            }
            return list;
        }

        //Admin

        private static bool IsExsitPhoneConfig(int RAM, int ROM)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                var query = from c in db.Configurations
                            where c.Configuration_RAM.Equals(RAM) && c.Configuration_ROM.Equals(ROM)
                            select c;
                return query.Any();
            }
        }

        private static int GetConfigurationIDFromRAMAndROM(int RAM, int ROM)
        {
            if (IsExsitPhoneConfig(RAM, ROM))
            {
                using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
                {
                    var query = from c in db.Configurations
                                where c.Configuration_RAM.Equals(RAM) && c.Configuration_ROM.Equals(ROM)
                                select c.Configuration_ID;

                    int configID = query.FirstOrDefault();
                    return configID;
                }
            }
            else
                return -1;
        }

        public static int GetQuantityOfPhoneByID(int phoneID)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (db.Phones.Any(p => p.Phone_ID == phoneID))
                    return -1;
                else
                {
                    var query = from p in db.Phones
                                where p.Phone_ID == phoneID
                                select p.Phone_ReadyInStock;
                    return query.FirstOrDefault();
                }
            }
        }

        public static void AddPhone(string phoneName, int manufacturerID, string phoneColor, double phonePrice, int phoneQuantityInStock, string imageURL1, int RAM, int ROM, string imageURL2 = null, bool isActive = true)
        {
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (IsExsitPhoneConfig(RAM, ROM))
                {
                    int configID = GetConfigurationIDFromRAMAndROM(RAM, ROM);
                    if (configID > 0)
                    {
                        Phone p = new Phone(phoneName, phoneColor, phonePrice, phoneQuantityInStock, manufacturerID, configID, isActive);
                        db.Phones.Add(p);

                        db.Images.Add(new Image(imageURL1, p.Phone_ID));
                        if (imageURL2 != "")
                        {
                            db.Images.Add(new Image(imageURL2, p.Phone_ID));
                        }
                    }
                    else
                        return;
                }
                else
                {
                    Configuration config = new Configuration(RAM, ROM);
                    db.Configurations.Add(config);

                    Phone p = new Phone(phoneName, phoneColor, phonePrice, phoneQuantityInStock, manufacturerID, config.Configuration_ID, isActive);
                    db.Phones.Add(p);

                    db.Images.Add(new Image(imageURL1, p.Phone_ID));
                    if (imageURL2 != "")
                    {
                        db.Images.Add(new Image(imageURL2, p.Phone_ID));
                    }
                }

                db.SaveChanges();
            }
        }

        private static List<Image> GetImagesOfPhoneByPhoneID(int phoneID)
        {
            List<Image> images = new List<Image>();
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (db.Phones.Any(p => p.Phone_ID == phoneID))
                {
                    var query = from i in db.Images
                                where i.Phone_ID == phoneID
                                select i;
                    images = query.ToList();
                }
            }
            return images;
        }

        public static bool UpdaePhoneInformation(int phoneID, string phoneName, int manufacturerID, string phoneColor, double phonePrice, int phoneQuantityInStock, string imageURL1, int RAM, int ROM, string imageURL2 = null, bool isActive = true)
        {
            bool isUpdated = false;
            using (OnlineSellingPhoneContext db = new OnlineSellingPhoneContext())
            {
                if (db.Phones.Any(p => p.Phone_ID == phoneID))
                {
                    Phone phone = db.Phones.FirstOrDefault(p => p.Phone_ID == phoneID);
                    phone.Phone_Name = phoneName;
                    phone.Phone_Price = phonePrice;
                    phone.Phone_Color = phoneColor;
                    phone.Phone_ReadyInStock = phoneQuantityInStock;
                    phone.Phone_Active = isActive;
                    phone.Manufacturer_ID = manufacturerID;

                    int configID = GetConfigurationIDFromRAMAndROM(RAM, ROM);
                    if (configID >= 0)
                    {
                        if (configID != phone.Configuration_ID)
                            phone.Configuration_ID = configID;
                    }

                    List<Image> images = new List<Image>();
                    images = GetImagesOfPhoneByPhoneID(phone.Phone_ID);

                    if (images != null && images.Count > 0)
                    {
                        if (images.Count > 0 && !string.IsNullOrEmpty(imageURL1))
                        {
                            images[0].Image_URL = imageURL1;
                            db.Entry(images[0]).State = System.Data.Entity.EntityState.Modified;
                        }

                        if (images.Count > 1)
                        {
                            images[1].Image_URL = imageURL2;
                            db.Entry(images[1]).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                    db.SaveChanges();
                    isUpdated = true;
                }
                else isUpdated = false;
                return isUpdated;
            }
        }
    }
}
