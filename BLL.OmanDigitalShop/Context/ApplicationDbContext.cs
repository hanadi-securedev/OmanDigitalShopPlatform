using DAL.OmanDigitalShop.Models.Orders;
using DAL.OmanDigitalShop.Models.Products;
using DAL.OmanDigitalShop.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.OmanDigitalShop.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { 

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }


        public DbSet<Product> Products { get; set; }

        // جدول الفئات
        public DbSet<Category> Categories { get; set; }

        // جدول الطلبات
        public DbSet<Order> Orders { get; set; }

        // جدول عناصر الطلبات
        public DbSet<OrderItem> OrderItems { get; set; }

        // جدول العناوين
        public DbSet<Address> Addresses { get; set; }



    }
}

