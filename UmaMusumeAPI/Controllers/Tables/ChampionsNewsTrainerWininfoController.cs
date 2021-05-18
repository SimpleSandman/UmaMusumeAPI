using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionsNewsTrainerWininfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsTrainerWininfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsTrainerWininfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsTrainerWininfo>>> GetChampionsNewsTrainerWininfos()
        {
            return await _context.ChampionsNewsTrainerWininfos.ToListAsync();
        }

        // GET: api/ChampionsNewsTrainerWininfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsTrainerWininfo>> GetChampionsNewsTrainerWininfo(int id)
        {
            var championsNewsTrainerWininfo = await _context.ChampionsNewsTrainerWininfos.FindAsync(id);

            if (championsNewsTrainerWininfo == null)
            {
                return NotFound();
            }

            return championsNewsTrainerWininfo;
        }

        // PUT: api/ChampionsNewsTrainerWininfo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsNewsTrainerWininfo(int id, ChampionsNewsTrainerWininfo championsNewsTrainerWininfo)
        {
            if (id != championsNewsTrainerWininfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsNewsTrainerWininfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsNewsTrainerWininfoExists(id))
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

        // POST: api/ChampionsNewsTrainerWininfo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsNewsTrainerWininfo>> PostChampionsNewsTrainerWininfo(ChampionsNewsTrainerWininfo championsNewsTrainerWininfo)
        {
            _context.ChampionsNewsTrainerWininfos.Add(championsNewsTrainerWininfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsNewsTrainerWininfoExists(championsNewsTrainerWininfo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsNewsTrainerWininfo", new { id = championsNewsTrainerWininfo.Id }, championsNewsTrainerWininfo);
        }

        // DELETE: api/ChampionsNewsTrainerWininfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsNewsTrainerWininfo(int id)
        {
            var championsNewsTrainerWininfo = await _context.ChampionsNewsTrainerWininfos.FindAsync(id);
            if (championsNewsTrainerWininfo == null)
            {
                return NotFound();
            }

            _context.ChampionsNewsTrainerWininfos.Remove(championsNewsTrainerWininfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsNewsTrainerWininfoExists(int id)
        {
            return _context.ChampionsNewsTrainerWininfos.Any(e => e.Id == id);
        }
    }
}
