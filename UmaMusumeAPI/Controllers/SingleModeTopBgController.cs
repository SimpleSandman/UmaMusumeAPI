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
    public class SingleModeTopBgController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTopBgController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTopBg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTopBg>>> GetSingleModeTopBgs()
        {
            return await _context.SingleModeTopBgs.ToListAsync();
        }

        // GET: api/SingleModeTopBg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTopBg>> GetSingleModeTopBg(int id)
        {
            var singleModeTopBg = await _context.SingleModeTopBgs.FindAsync(id);

            if (singleModeTopBg == null)
            {
                return NotFound();
            }

            return singleModeTopBg;
        }

        // PUT: api/SingleModeTopBg/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeTopBg(int id, SingleModeTopBg singleModeTopBg)
        {
            if (id != singleModeTopBg.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeTopBg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeTopBgExists(id))
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

        // POST: api/SingleModeTopBg
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeTopBg>> PostSingleModeTopBg(SingleModeTopBg singleModeTopBg)
        {
            _context.SingleModeTopBgs.Add(singleModeTopBg);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeTopBgExists(singleModeTopBg.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeTopBg", new { id = singleModeTopBg.Id }, singleModeTopBg);
        }

        // DELETE: api/SingleModeTopBg/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeTopBg(int id)
        {
            var singleModeTopBg = await _context.SingleModeTopBgs.FindAsync(id);
            if (singleModeTopBg == null)
            {
                return NotFound();
            }

            _context.SingleModeTopBgs.Remove(singleModeTopBg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeTopBgExists(int id)
        {
            return _context.SingleModeTopBgs.Any(e => e.Id == id);
        }
    }
}
