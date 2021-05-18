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
    public class RaceBgmController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBgmController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBgm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBgm>>> GetRaceBgms()
        {
            return await _context.RaceBgms.ToListAsync();
        }

        // GET: api/RaceBgm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBgm>> GetRaceBgm(int id)
        {
            var raceBgm = await _context.RaceBgms.FindAsync(id);

            if (raceBgm == null)
            {
                return NotFound();
            }

            return raceBgm;
        }

        // PUT: api/RaceBgm/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceBgm(int id, RaceBgm raceBgm)
        {
            if (id != raceBgm.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceBgm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceBgmExists(id))
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

        // POST: api/RaceBgm
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceBgm>> PostRaceBgm(RaceBgm raceBgm)
        {
            _context.RaceBgms.Add(raceBgm);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceBgmExists(raceBgm.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceBgm", new { id = raceBgm.Id }, raceBgm);
        }

        // DELETE: api/RaceBgm/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceBgm(int id)
        {
            var raceBgm = await _context.RaceBgms.FindAsync(id);
            if (raceBgm == null)
            {
                return NotFound();
            }

            _context.RaceBgms.Remove(raceBgm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceBgmExists(int id)
        {
            return _context.RaceBgms.Any(e => e.Id == id);
        }
    }
}
