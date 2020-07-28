using Microsoft.EntityFrameworkCore;
using PetFinder.Core.Entities;

namespace PetFinder.Domain.Data
{
    public class PetFinderContext : DbContext
    {
        public PetFinderContext(DbContextOptions<PetFinderContext> options) : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
    }
}
