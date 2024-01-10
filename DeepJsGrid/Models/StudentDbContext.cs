using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DeepJsGrid.Models
{
     public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
