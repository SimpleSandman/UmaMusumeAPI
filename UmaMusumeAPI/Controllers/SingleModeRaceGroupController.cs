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
    public class SingleModeRaceGroupController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRaceGroupController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRaceGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRaceGroup>>> GetSingleModeRaceGroups()
        {
            return await _context.SingleModeRaceGroups.ToListAsync();
        }

        // GET: api/SingleModeRaceGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRaceGroup>> GetSingleModeRaceGroup(int id)
        {
            var singleModeRaceGroup = await _context.SingleModeRaceGroups.FindAsync(id);

            if (singleModeRaceGroup == null)
            {
                return NotFound();
            }

            return singleModeRaceGroup;
        }

        // PUT: api/SingleModeRaceGroup/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRaceGroup(int id, SingleModeRaceGroup singleModeRaceGroup)
        {
            if (id != singleModeRaceGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRaceGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRaceGroupExists(id))
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

        // POST: api/SingleModeRaceGroup
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRaceGroup>> PostSingleModeRaceGroup(SingleModeRaceGroup singleModeRaceGroup)
        {
            _context.SingleModeRaceGroups.Add(singleModeRaceGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRaceGroupExists(singleModeRaceGroup.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRaceGroup", new { id = singleModeRaceGroup.Id }, singleModeRaceGroup);
        }

        // DELETE: api/SingleModeRaceGroup/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRaceGroup(int id)
        {
            var singleModeRaceGroup = await _context.SingleModeRaceGroups.FindAsync(id);
            if (singleModeRaceGroup == null)
            {
                return NotFound();
            }

            _context.SingleModeRaceGroups.Remove(singleModeRaceGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRaceGroupExists(int id)
        {
            return _context.SingleModeRaceGroups.Any(e => e.Id == id);
        }
    }
}
