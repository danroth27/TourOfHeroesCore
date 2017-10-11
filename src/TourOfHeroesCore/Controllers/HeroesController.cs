using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TourOfHeroesCore.Data;

namespace TourOfHeroesCore.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        private readonly HeroesContext _context;

        public HeroesController(HeroesContext context)
        {
            _context = context;
        }

        // GET: api/Heroes
        [HttpGet]
        public IEnumerable<Hero> GetHeroes(string name)
        {
            return !String.IsNullOrEmpty(name) ?
                _context.Heroes.Where(hero => hero.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) :
                _context.Heroes;
        }

        // GET: api/Heroes/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Hero), 200)]
        public async Task<IActionResult> GetHero([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hero = await _context.Heroes.SingleOrDefaultAsync(m => m.Id == id);

            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        // PUT: api/Heroes/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Hero), 200)]
        public async Task<IActionResult> PutHero([FromRoute] int id, [FromBody] Hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hero.Id)
            {
                return BadRequest();
            }

            _context.Entry(hero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Heroes
        [HttpPost]
        [ProducesResponseType(typeof(Hero), 201)]
        public async Task<IActionResult> PostHero([FromBody] Hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Heroes.Add(hero);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHero", new { id = hero.Id }, hero);
        }

        // DELETE: api/Heroes/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Hero), 200)]
        public async Task<IActionResult> DeleteHero([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hero = await _context.Heroes.SingleOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();

            return Ok(hero);
        }

        private bool HeroExists(int id)
        {
            return _context.Heroes.Any(e => e.Id == id);
        }
    }
}