
using Conductor.Models;
using Microsoft.EntityFrameworkCore;

namespace Conductor.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
        public DbSet<Payment> Payments { get; set; }
    }
}