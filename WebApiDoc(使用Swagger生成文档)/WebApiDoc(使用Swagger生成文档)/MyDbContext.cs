using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using WebApiDoc_使用Swagger生成文档_.Models;

namespace WebApiDoc_使用Swagger生成文档_
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("name=product")
        {



        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}