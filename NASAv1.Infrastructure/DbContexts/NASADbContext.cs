using Microsoft.EntityFrameworkCore;
using NASAv1.Domain.Entities;

namespace NASAv1.Infrastructure.DbContexts
{
    public class NASADbContext : DbContext
    {
        public NASADbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Rocket> Rockets { get; set; }
        DbSet<Satellite> Satellite { get; set; }
    }
}
