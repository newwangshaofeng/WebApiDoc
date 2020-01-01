using WebApiDoc_使用Swagger生成文档_.Models;

namespace WebApiDoc_使用Swagger生成文档_.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiDoc_使用Swagger生成文档_.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiDoc_使用Swagger生成文档_.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(new Product(){Id = 1,Name = "C++",Category = "language",Price = 25});
            context.Products.AddOrUpdate(new Product() { Id = 1, Name = "html", Category = "language", Price = 50 });
            context.Products.AddOrUpdate(new Product() { Id = 1, Name = "Java", Category = "language", Price = 100 });
            context.Products.AddOrUpdate(new Product() { Id = 1, Name = "css", Category = "language", Price = 123 });
            context.Products.AddOrUpdate(new Product() { Id = 1, Name = "Html", Category = "design", Price = 225 });
            context.Products.AddOrUpdate(new Product() { Id = 1, Name = "PHP", Category = "language", Price = 362 });

        }
    }
}
