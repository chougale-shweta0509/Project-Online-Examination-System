using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Data.Entity
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {
            
        }
        public StudentDbContext(DbContextOptions<StudentDbContext> options):
            base(options)
        {
            
        }

        public DbSet<Exams>Exmas { get; set; }

        public DbSet<ExamResults> ExamResults { get; set; }

        public DbSet<Groups> Groups { get; set; }

        public DbSet<QnAs> QnAs { get; set; }

        public DbSet<Students> Students { get; set; }

        public DbSet<Users> Users { get; set; }
    
    }
}
