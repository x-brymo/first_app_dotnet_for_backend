using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using first_app.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryBook
{
  public class BookDbContext : DbContext 
  {
    public BookDbContext( DbContextOptions<BookDbContext> options) : base (options){}
    public DbSet<BookEntity> Books { get; set; } // <==>
  }
}
