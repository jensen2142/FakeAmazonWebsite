using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Mission11_Hermansen.Models
{
    public class AmazonContext : DbContext
    {
        public AmazonContext (DbContextOptions<AmazonContext> options) : base(options){ }
        public DbSet<Books> Books { get; set; }
    }
}
