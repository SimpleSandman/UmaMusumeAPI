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
    public class ChampionsRoundDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRoundDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRoundDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRoundDetail>>> GetChampionsRoundDetails()
        {
            return await _context.ChampionsRoundDetails.ToListAsync();
        }

        // GET: api/ChampionsRoundDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsRoundDetail>> GetChampionsRoundDetail(int id)
        {
            var championsRoundDetail = await _context.ChampionsRoundDetails.FindAsync(id);

            if (championsRoundDetail == null)
            {
                return NotFound();
            }

            return championsRoundDetail;
        }

        // PUT: api/ChampionsRoundDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsRoundDetail(int id, ChampionsRoundDetail championsRoundDetail)
        {
            if (id != championsRoundDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsRoundDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsRoundDetailExists(id))
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

        // POST: api/ChampionsRoundDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsRoundDetail>> PostChampionsRoundDetail(ChampionsRoundDetail championsRoundDetail)
        {
            _context.ChampionsRoundDetails.Add(championsRoundDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsRoundDetailExists(championsRoundDetail.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsRoundDetail", new { id = championsRoundDetail.Id }, championsRoundDetail);
        }

        // DELETE: api/ChampionsRoundDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsRoundDetail(int id)
        {
            var championsRoundDetail = await _context.ChampionsRoundDetails.FindAsync(id);
            if (championsRoundDetail == null)
            {
                return NotFound();
            }

            _context.ChampionsRoundDetails.Remove(championsRoundDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsRoundDetailExists(int id)
        {
            return _context.ChampionsRoundDetails.Any(e => e.Id == id);
        }
    }
}
