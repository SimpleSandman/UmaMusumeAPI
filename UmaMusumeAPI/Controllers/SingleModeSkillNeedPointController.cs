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
    public class SingleModeSkillNeedPointController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeSkillNeedPointController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeSkillNeedPoint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeSkillNeedPoint>>> GetSingleModeSkillNeedPoints()
        {
            return await _context.SingleModeSkillNeedPoints.ToListAsync();
        }

        // GET: api/SingleModeSkillNeedPoint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeSkillNeedPoint>> GetSingleModeSkillNeedPoint(int id)
        {
            var singleModeSkillNeedPoint = await _context.SingleModeSkillNeedPoints.FindAsync(id);

            if (singleModeSkillNeedPoint == null)
            {
                return NotFound();
            }

            return singleModeSkillNeedPoint;
        }

        // PUT: api/SingleModeSkillNeedPoint/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeSkillNeedPoint(int id, SingleModeSkillNeedPoint singleModeSkillNeedPoint)
        {
            if (id != singleModeSkillNeedPoint.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeSkillNeedPoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeSkillNeedPointExists(id))
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

        // POST: api/SingleModeSkillNeedPoint
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeSkillNeedPoint>> PostSingleModeSkillNeedPoint(SingleModeSkillNeedPoint singleModeSkillNeedPoint)
        {
            _context.SingleModeSkillNeedPoints.Add(singleModeSkillNeedPoint);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeSkillNeedPointExists(singleModeSkillNeedPoint.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeSkillNeedPoint", new { id = singleModeSkillNeedPoint.Id }, singleModeSkillNeedPoint);
        }

        // DELETE: api/SingleModeSkillNeedPoint/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeSkillNeedPoint(int id)
        {
            var singleModeSkillNeedPoint = await _context.SingleModeSkillNeedPoints.FindAsync(id);
            if (singleModeSkillNeedPoint == null)
            {
                return NotFound();
            }

            _context.SingleModeSkillNeedPoints.Remove(singleModeSkillNeedPoint);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeSkillNeedPointExists(int id)
        {
            return _context.SingleModeSkillNeedPoints.Any(e => e.Id == id);
        }
    }
}
