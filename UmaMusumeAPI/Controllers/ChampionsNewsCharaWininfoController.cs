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
    public class ChampionsNewsCharaWininfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsCharaWininfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsCharaWininfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsCharaWininfo>>> GetChampionsNewsCharaWininfos()
        {
            return await _context.ChampionsNewsCharaWininfos.ToListAsync();
        }

        // GET: api/ChampionsNewsCharaWininfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsCharaWininfo>> GetChampionsNewsCharaWininfo(int id)
        {
            var championsNewsCharaWininfo = await _context.ChampionsNewsCharaWininfos.FindAsync(id);

            if (championsNewsCharaWininfo == null)
            {
                return NotFound();
            }

            return championsNewsCharaWininfo;
        }

        // PUT: api/ChampionsNewsCharaWininfo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsNewsCharaWininfo(int id, ChampionsNewsCharaWininfo championsNewsCharaWininfo)
        {
            if (id != championsNewsCharaWininfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsNewsCharaWininfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsNewsCharaWininfoExists(id))
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

        // POST: api/ChampionsNewsCharaWininfo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsNewsCharaWininfo>> PostChampionsNewsCharaWininfo(ChampionsNewsCharaWininfo championsNewsCharaWininfo)
        {
            _context.ChampionsNewsCharaWininfos.Add(championsNewsCharaWininfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsNewsCharaWininfoExists(championsNewsCharaWininfo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsNewsCharaWininfo", new { id = championsNewsCharaWininfo.Id }, championsNewsCharaWininfo);
        }

        // DELETE: api/ChampionsNewsCharaWininfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsNewsCharaWininfo(int id)
        {
            var championsNewsCharaWininfo = await _context.ChampionsNewsCharaWininfos.FindAsync(id);
            if (championsNewsCharaWininfo == null)
            {
                return NotFound();
            }

            _context.ChampionsNewsCharaWininfos.Remove(championsNewsCharaWininfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsNewsCharaWininfoExists(int id)
        {
            return _context.ChampionsNewsCharaWininfos.Any(e => e.Id == id);
        }
    }
}
