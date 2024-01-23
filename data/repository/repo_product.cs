using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using first_app.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryProduct
{
  public class ProductDbContext : DbContext 
  {
    public ProductDbContext( DbContextOptions<ProductDbContext> options) : base (options){}
    public DbSet<ProductEntity> Products { get; set; } // <==>
  }
}
