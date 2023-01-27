using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GamesProject.Server.Data;
using GamesProject.Shared.Domain;

namespace GamesProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeRatingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AgeRatingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AgeRatings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgeRating>>> GetAgeRatings()
        {
            return await _context.AgeRatings.ToListAsync();
        }

        // GET: api/AgeRatings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AgeRating>> GetAgeRating(int id)
        {
            var ageRating = await _context.AgeRatings.FindAsync(id);

            if (ageRating == null)
            {
                return NotFound();
            }

            return ageRating;
        }

        // PUT: api/AgeRatings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgeRating(int id, AgeRating ageRating)
        {
            if (id != ageRating.Id)
            {
                return BadRequest();
            }

            _context.Entry(ageRating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgeRatingExists(id))
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

        // POST: api/AgeRatings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AgeRating>> PostAgeRating(AgeRating ageRating)
        {
            _context.AgeRatings.Add(ageRating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgeRating", new { id = ageRating.Id }, ageRating);
        }

        // DELETE: api/AgeRatings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgeRating(int id)
        {
            var ageRating = await _context.AgeRatings.FindAsync(id);
            if (ageRating == null)
            {
                return NotFound();
            }

            _context.AgeRatings.Remove(ageRating);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgeRatingExists(int id)
        {
            return _context.AgeRatings.Any(e => e.Id == id);
        }
    }
}
