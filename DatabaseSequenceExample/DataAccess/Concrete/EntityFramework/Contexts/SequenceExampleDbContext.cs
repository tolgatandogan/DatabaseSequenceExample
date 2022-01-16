using DatabaseSequenceExample.Core.Manager;
using DatabaseSequenceExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.DataAccess.Concrete.EntityFramework.Contexts
{
    public class SequenceExampleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: AppSetting.GetDbConn());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        DbSet<Company> Companies { get; set; }
        DbSet<Customer> Customers { get; set; }
    }
}
