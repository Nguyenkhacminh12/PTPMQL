using Microsoft.entityDrameworkCore;
using BaiTap.Models;
namespace BaiTap.DATA
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
         { }
         public DbSet<Student> Students { get; set; }
    }
}