using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using campany.data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace campany.data.context
{
    public class campanyDbContext : IdentityDbContext<ApplicationUser>
    {
        public campanyDbContext()
        {
           
        }

        public campanyDbContext(DbContextOptions options) : base(options)
        {
        }

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer("server=.; database=CompanyMVCG01; trusted_connections =true;");
         }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // modelBuilder.Entity<BaseEntity>().HasQueryFilter(x => !x.isdeleted);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

    }
}
