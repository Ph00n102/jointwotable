using Microsoft.EntityFrameworkCore;

namespace foreignkeyrelationship_student_skills.Models
{
    public class mycontext : DbContext
    {
        public mycontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<skill> skills { get; set; }
        public DbSet<student> students { get; set; }
    }
}
