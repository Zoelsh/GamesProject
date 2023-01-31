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
    public class GamePublishersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamePublishersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GamePublishers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GamePublisher>>> GetGamePublishers()
        {
            return await _context.GamePublishers.ToListAsync();
        }

        // GET: api/GamePublishers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GamePublisher>> GetGamePublisher(int id)
        {
            var gamePublisher = await _context.GamePublishers.FindAsync(id);

            if (gamePublisher == null)
            {
                return NotFound();
            }

            return gamePublisher;
        }

        // PUT: api/GamePublishers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGamePublisher(int id, GamePublisher gamePublisher)
        {
            if (id != gamePublisher.Id)
            {
                return BadRequest();
            }

            _context.Entry(gamePublisher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GamePublisherExists(id))
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

        // POST: api/GamePublishers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GamePublisher>> PostGamePublisher(GamePublisher gamePublisher)
        {
            _context.GamePublishers.Add(gamePublisher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGamePublisher", new { id = gamePublisher.Id }, gamePublisher);
        }

        // DELETE: api/GamePublishers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGamePublisher(int id)
        {
            var gamePublisher = await _context.GamePublishers.FindAsync(id);
            if (gamePublisher == null)
            {
                return NotFound();
            }

            _context.GamePublishers.Remove(gamePublisher);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GamePublisherExists(int id)
        {
            return _context.GamePublishers.Any(e => e.Id == id);
        }
    }
}
