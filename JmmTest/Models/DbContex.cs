using Microsoft.EntityFrameworkCore;

namespace JmmTest.Models
{
    public class DbContex :DbContext
    {
        public DbContex(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Jmm> JmmTest { get; set; }
    }
}
