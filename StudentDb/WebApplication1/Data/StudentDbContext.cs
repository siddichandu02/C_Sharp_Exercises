using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentDb.Models;

namespace StudentDb.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext (DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentDb.Models.Student> Student { get; set; }

        public DbSet<StudentDb.Models.Faculty> Faculty { get; set; }
    }
}
