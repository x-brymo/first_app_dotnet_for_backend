using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using first_app.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryStudent
{
  public class StudentDbContext : DbContext 
  {
    public StudentDbContext( DbContextOptions<StudentDbContext> options) : base (options){}
    public DbSet<StudentEntity> Students { get; set; } // <==>
  }
}
