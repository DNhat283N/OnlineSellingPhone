using DataLayer.Enities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EF
{
    public class OnlineSellingPhoneContext:DbContext
    {
        public OnlineSellingPhoneContext() : base(@"Server=.;Database=OnlineSellingPhoneDatabase;Trusted_Connection=True")
        {
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressOfCustomer> AddressOfCustomers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Configuration> Configurations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(p => p.Customer_BirthDay)
                .HasColumnType("Date");

            modelBuilder.Entity<Account>()
                .Property(p => p.Account_Username)
                .HasColumnType("nvarchar");

            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.Entity<Customer>().ToTable("Customers");
                
        }

    }
}
