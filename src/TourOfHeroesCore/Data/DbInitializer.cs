using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace TourOfHeroesCore.Data
{
    public class DbInitializer
    {
        private static readonly string[] Heroes = new[] 
        {
            "Mr. Nice",
            "Narco",
            "Bombasto",
            "Celeritas",
            "Magneta",
            "RubberMan",
            "Dynama",
            "Dr IQ",
            "Magma",
            "Tornado"
        };

        private readonly HeroesContext _context;

        public DbInitializer(HeroesContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Heroes.Any())
            {
                return;
            }

            _context.Heroes.AddRange(Heroes.Select(name => new Hero { Name = name }));
            _context.SaveChanges();
        }
    }
}
