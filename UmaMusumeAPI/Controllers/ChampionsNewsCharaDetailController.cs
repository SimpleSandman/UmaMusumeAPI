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
    public class ChampionsNewsCharaDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsCharaDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsCharaDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsCharaDetail>>> GetChampionsNewsCharaDetails()
        {
            return await _context.ChampionsNewsCharaDetails.ToListAsync();
        }

        // GET: api/ChampionsNewsCharaDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsCharaDetail>> GetChampionsNewsCharaDetail(int id)
        {
            var championsNewsCharaDetail = await _context.ChampionsNewsCharaDetails.FindAsync(id);

            if (championsNewsCharaDetail == null)
            {
                return NotFound();
            }

            return championsNewsCharaDetail;
        }

        // PUT: api/ChampionsNewsCharaDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsNewsCharaDetail(int id, ChampionsNewsCharaDetail championsNewsCharaDetail)
        {
            if (id != championsNewsCharaDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsNewsCharaDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsNewsCharaDetailExists(id))
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

        // POST: api/ChampionsNewsCharaDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsNewsCharaDetail>> PostChampionsNewsCharaDetail(ChampionsNewsCharaDetail championsNewsCharaDetail)
        {
            _context.ChampionsNewsCharaDetails.Add(championsNewsCharaDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsNewsCharaDetailExists(championsNewsCharaDetail.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsNewsCharaDetail", new { id = championsNewsCharaDetail.Id }, championsNewsCharaDetail);
        }

        // DELETE: api/ChampionsNewsCharaDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsNewsCharaDetail(int id)
        {
            var championsNewsCharaDetail = await _context.ChampionsNewsCharaDetails.FindAsync(id);
            if (championsNewsCharaDetail == null)
            {
                return NotFound();
            }

            _context.ChampionsNewsCharaDetails.Remove(championsNewsCharaDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsNewsCharaDetailExists(int id)
        {
            return _context.ChampionsNewsCharaDetails.Any(e => e.Id == id);
        }
    }
}
