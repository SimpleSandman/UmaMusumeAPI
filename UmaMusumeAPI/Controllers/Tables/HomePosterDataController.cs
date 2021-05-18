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
    public class HomePosterDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomePosterDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomePosterData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomePosterData>>> GetHomePosterData()
        {
            return await _context.HomePosterData.ToListAsync();
        }

        // GET: api/HomePosterData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomePosterData>> GetHomePosterData(int id)
        {
            var homePosterData = await _context.HomePosterData.FindAsync(id);

            if (homePosterData == null)
            {
                return NotFound();
            }

            return homePosterData;
        }

        // PUT: api/HomePosterData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomePosterData(int id, HomePosterData homePosterData)
        {
            if (id != homePosterData.Id)
            {
                return BadRequest();
            }

            _context.Entry(homePosterData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomePosterDataExists(id))
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

        // POST: api/HomePosterData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HomePosterData>> PostHomePosterData(HomePosterData homePosterData)
        {
            _context.HomePosterData.Add(homePosterData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HomePosterDataExists(homePosterData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHomePosterData", new { id = homePosterData.Id }, homePosterData);
        }

        // DELETE: api/HomePosterData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomePosterData(int id)
        {
            var homePosterData = await _context.HomePosterData.FindAsync(id);
            if (homePosterData == null)
            {
                return NotFound();
            }

            _context.HomePosterData.Remove(homePosterData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomePosterDataExists(int id)
        {
            return _context.HomePosterData.Any(e => e.Id == id);
        }
    }
}
