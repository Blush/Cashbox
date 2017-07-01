using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace Cashbox.Models
{
    public class DataContext : DbContext
    {

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Check> Checks { get; set; }
        public virtual DbSet<StoredProduct> StoreProducts { get; set; }
        public virtual DbSet<CheckProduct> CheckProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder bld)
        {
            base.OnModelCreating(bld);

        }


        public DataContext() : base(DefaultConnectionString)
		{

        }
        public DataContext(string connectionString) : base(connectionString)
		{

        }

        public static string DefaultConnectionString
        { get { return ConfigurationManager.ConnectionStrings["Context"].ConnectionString; } }
    }
}
