using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiDoc_使用Swagger生成文档_.Models;

namespace WebApiDoc_使用Swagger生成文档_.ModelConfig
{
    public class ProductConfig:EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            this.ToTable("T_Product");
        }
    }
}