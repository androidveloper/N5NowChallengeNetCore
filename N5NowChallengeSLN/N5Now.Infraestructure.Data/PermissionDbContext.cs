using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions ;
using Microsoft.Extensions.Configuration;
using N5Now.Domain.Entity;

namespace N5Now.Infraestructure.Data
{
    public class PermissionDbContext : DbContext
    {

        public PermissionDbContext(DbContextOptions<PermissionDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    // Additional configuration can go here.
        //}

       
    }
}
