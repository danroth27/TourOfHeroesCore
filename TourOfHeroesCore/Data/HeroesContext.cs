using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourOfHeroesCore.Data;

    public class HeroesContext : DbContext
    {
        public HeroesContext (DbContextOptions<HeroesContext> options)
            : base(options)
        {
        }

        public DbSet<TourOfHeroesCore.Data.Hero> Hero { get; set; }
    }
