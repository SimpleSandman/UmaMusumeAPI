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
    public class SingleModeNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeNpc>>> GetSingleModeNpcs()
        {
            return await _context.SingleModeNpcs.ToListAsync();
        }

        // GET: api/SingleModeNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeNpc>> GetSingleModeNpc(int id)
        {
            var singleModeNpc = await _context.SingleModeNpcs.FindAsync(id);

            if (singleModeNpc == null)
            {
                return NotFound();
            }

            return singleModeNpc;
        }

        // PUT: api/SingleModeNpc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeNpc(int id, SingleModeNpc singleModeNpc)
        {
            if (id != singleModeNpc.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeNpc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeNpcExists(id))
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

        // POST: api/SingleModeNpc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeNpc>> PostSingleModeNpc(SingleModeNpc singleModeNpc)
        {
            _context.SingleModeNpcs.Add(singleModeNpc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeNpcExists(singleModeNpc.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeNpc", new { id = singleModeNpc.Id }, singleModeNpc);
        }

        // DELETE: api/SingleModeNpc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeNpc(int id)
        {
            var singleModeNpc = await _context.SingleModeNpcs.FindAsync(id);
            if (singleModeNpc == null)
            {
                return NotFound();
            }

            _context.SingleModeNpcs.Remove(singleModeNpc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeNpcExists(int id)
        {
            return _context.SingleModeNpcs.Any(e => e.Id == id);
        }
    }
}
