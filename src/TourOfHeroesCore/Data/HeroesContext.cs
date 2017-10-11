using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TourOfHeroesCore.Data
{
    public class HeroesContext : DbContext
    {
        public HeroesContext(DbContextOptions<HeroesContext> options) : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
