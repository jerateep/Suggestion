using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SGO.Models.MySQL;

namespace SGO.Web.Data
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }
        public DbSet<SGO_Approver> SGO_Approver { get; set; }
        public DbSet<SGO_Department> SGO_Department { get; set; }
        public DbSet<SGO_HEAD> SGO_HEAD { get; set; }
        public DbSet<SGO_Status> SGO_Status { get; set; }
        public DbSet<SGO_TEAM> SGO_TEAM { get; set; }
        public DbSet<SGO_Type> SGO_Type { get; set; }
        public DbSet<SGO_SHIFT> SGO_SHIFT { get; set; }
        public DbSet<SGO_Files> SGO_Files { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=Demo;user=root;password=Abc@12345");
            }
        }
    }
}
