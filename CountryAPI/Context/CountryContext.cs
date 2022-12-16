using CountryAPI.Moedel;
using Microsoft.EntityFrameworkCore;

namespace CountryAPI.Context
{
    public class CountryContext: DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }

        public DbSet<CountryItem> countryItems { get; set; } = null!;
    }
}
