using Microsoft.AspNetCore;
using JoaoArthur.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JoaoArthur.Data
{
    public class AppDbContext : IdentityDbContext<Psico>
    {
        
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

            public DbSet<Psico> psicos { get; set; }
        
    }
    
}
