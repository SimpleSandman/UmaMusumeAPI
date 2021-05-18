using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceJikkyoMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoMessage>>> GetRaceJikkyoMessages()
        {
            return await _context.RaceJikkyoMessages.ToListAsync();
        }

        // GET: api/RaceJikkyoMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoMessage>> GetRaceJikkyoMessage(int id)
        {
            var raceJikkyoMessage = await _context.RaceJikkyoMessages.FindAsync(id);

            if (raceJikkyoMessage == null)
            {
                return NotFound();
            }

            return raceJikkyoMessage;
        }

        // PUT: api/RaceJikkyoMessage/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceJikkyoMessage(int id, RaceJikkyoMessage raceJikkyoMessage)
        {
            if (id != raceJikkyoMessage.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceJikkyoMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceJikkyoMessageExists(id))
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

        // POST: api/RaceJikkyoMessage
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceJikkyoMessage>> PostRaceJikkyoMessage(RaceJikkyoMessage raceJikkyoMessage)
        {
            _context.RaceJikkyoMessages.Add(raceJikkyoMessage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceJikkyoMessageExists(raceJikkyoMessage.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceJikkyoMessage", new { id = raceJikkyoMessage.Id }, raceJikkyoMessage);
        }

        // DELETE: api/RaceJikkyoMessage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceJikkyoMessage(int id)
        {
            var raceJikkyoMessage = await _context.RaceJikkyoMessages.FindAsync(id);
            if (raceJikkyoMessage == null)
            {
                return NotFound();
            }

            _context.RaceJikkyoMessages.Remove(raceJikkyoMessage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceJikkyoMessageExists(int id)
        {
            return _context.RaceJikkyoMessages.Any(e => e.Id == id);
        }
    }
}
