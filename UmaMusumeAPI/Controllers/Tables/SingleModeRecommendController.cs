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
    public class SingleModeRecommendController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRecommendController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRecommend
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRecommend>>> GetSingleModeRecommends()
        {
            return await _context.SingleModeRecommends.ToListAsync();
        }

        // GET: api/SingleModeRecommend/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRecommend>> GetSingleModeRecommend(int id)
        {
            var singleModeRecommend = await _context.SingleModeRecommends.FindAsync(id);

            if (singleModeRecommend == null)
            {
                return NotFound();
            }

            return singleModeRecommend;
        }

        // PUT: api/SingleModeRecommend/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRecommend(int id, SingleModeRecommend singleModeRecommend)
        {
            if (id != singleModeRecommend.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRecommend).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRecommendExists(id))
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

        // POST: api/SingleModeRecommend
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRecommend>> PostSingleModeRecommend(SingleModeRecommend singleModeRecommend)
        {
            _context.SingleModeRecommends.Add(singleModeRecommend);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRecommendExists(singleModeRecommend.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRecommend", new { id = singleModeRecommend.Id }, singleModeRecommend);
        }

        // DELETE: api/SingleModeRecommend/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRecommend(int id)
        {
            var singleModeRecommend = await _context.SingleModeRecommends.FindAsync(id);
            if (singleModeRecommend == null)
            {
                return NotFound();
            }

            _context.SingleModeRecommends.Remove(singleModeRecommend);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRecommendExists(int id)
        {
            return _context.SingleModeRecommends.Any(e => e.Id == id);
        }
    }
}
