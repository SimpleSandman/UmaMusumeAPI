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
    public class ChampionsNewsTrainerDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsTrainerDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsTrainerDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsTrainerDetail>>> GetChampionsNewsTrainerDetails()
        {
            return await _context.ChampionsNewsTrainerDetails.ToListAsync();
        }

        // GET: api/ChampionsNewsTrainerDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsTrainerDetail>> GetChampionsNewsTrainerDetail(int id)
        {
            var championsNewsTrainerDetail = await _context.ChampionsNewsTrainerDetails.FindAsync(id);

            if (championsNewsTrainerDetail == null)
            {
                return NotFound();
            }

            return championsNewsTrainerDetail;
        }

        // PUT: api/ChampionsNewsTrainerDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsNewsTrainerDetail(int id, ChampionsNewsTrainerDetail championsNewsTrainerDetail)
        {
            if (id != championsNewsTrainerDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsNewsTrainerDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsNewsTrainerDetailExists(id))
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

        // POST: api/ChampionsNewsTrainerDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsNewsTrainerDetail>> PostChampionsNewsTrainerDetail(ChampionsNewsTrainerDetail championsNewsTrainerDetail)
        {
            _context.ChampionsNewsTrainerDetails.Add(championsNewsTrainerDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsNewsTrainerDetailExists(championsNewsTrainerDetail.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsNewsTrainerDetail", new { id = championsNewsTrainerDetail.Id }, championsNewsTrainerDetail);
        }

        // DELETE: api/ChampionsNewsTrainerDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsNewsTrainerDetail(int id)
        {
            var championsNewsTrainerDetail = await _context.ChampionsNewsTrainerDetails.FindAsync(id);
            if (championsNewsTrainerDetail == null)
            {
                return NotFound();
            }

            _context.ChampionsNewsTrainerDetails.Remove(championsNewsTrainerDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsNewsTrainerDetailExists(int id)
        {
            return _context.ChampionsNewsTrainerDetails.Any(e => e.Id == id);
        }
    }
}
