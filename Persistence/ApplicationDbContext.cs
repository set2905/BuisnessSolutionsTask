using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        int providerIds = 0;
        var providerFaker = new Faker<Provider>("ru")
            .StrictMode(true)
            .RuleFor(x => x.Id, f => new(providerIds++))
            .RuleFor(x => x.Name, f => f.Company.CompanyName());
        Provider[] fakeProviders = providerFaker.Generate(100).ToArray();
        modelBuilder.Entity<Provider>().HasData(fakeProviders);
    }
}