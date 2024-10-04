using CodeFirstBasic.Data;
using CodeFirstBasic.Data.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFirstBasic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDSController : ControllerBase
    {
        private readonly PatikaFirstDbContext _context;

        public CRUDSController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        // GET: api/CRUDS
        [HttpGet ("Game")]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
        {
            return await _context.Games.ToListAsync(); // Use the Game entity
        }

        // GET: api/CRUDS/5
        [HttpGet("Game/{id}")]
        public async Task<ActionResult<Game>> GetGame(int id)
        {
            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // POST: api/CRUDS
        [HttpPost("Game")]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGame), new { id = game.Id }, game); 
        }

        // PUT: api/CRUDS/5
        [HttpPut("Game/{id}")]
        public async Task<IActionResult> PutGame(int id, Game game)
        {
          

            _context.Entry(game).State = EntityState.Modified;

            
                await _context.SaveChangesAsync();
           
            return NoContent();
        }

        // DELETE: api/CRUDS/5
        [HttpDelete("Game/{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
    }
}
