using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourOfHeroesCore.Data;

public class HeroesContext : DbContext
{
    public HeroesContext(DbContextOptions<HeroesContext> options)
        : base(options)
    {
    }

    public DbSet<TourOfHeroesCore.Data.Hero> Hero { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hero>().HasData
          (
            new Hero { Id = 1, Name = "Mr. Nice" },
            new Hero { Id = 2, Name = "Narco" },
            new Hero { Id = 3, Name = "Bombasto" },
            new Hero { Id = 4, Name = "Celeritas" },
            new Hero { Id = 5, Name = "Magneta" },
            new Hero { Id = 6, Name = "RubberMan" },
            new Hero { Id = 7, Name = "Dynama" },
            new Hero { Id = 8, Name = "Dr IQ" },
            new Hero { Id = 9, Name = "Magma" },
            new Hero { Id = 10, Name = "Tornado"}
          );
    }
}
