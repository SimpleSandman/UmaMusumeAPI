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
    public class HomeWalkGroupController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeWalkGroupController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeWalkGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeWalkGroup>>> GetHomeWalkGroups()
        {
            return await _context.HomeWalkGroups.ToListAsync();
        }

        // GET: api/HomeWalkGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeWalkGroup>> GetHomeWalkGroup(int id)
        {
            var homeWalkGroup = await _context.HomeWalkGroups.FindAsync(id);

            if (homeWalkGroup == null)
            {
                return NotFound();
            }

            return homeWalkGroup;
        }

        // PUT: api/HomeWalkGroup/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomeWalkGroup(int id, HomeWalkGroup homeWalkGroup)
        {
            if (id != homeWalkGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(homeWalkGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomeWalkGroupExists(id))
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

        // POST: api/HomeWalkGroup
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HomeWalkGroup>> PostHomeWalkGroup(HomeWalkGroup homeWalkGroup)
        {
            _context.HomeWalkGroups.Add(homeWalkGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HomeWalkGroupExists(homeWalkGroup.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHomeWalkGroup", new { id = homeWalkGroup.Id }, homeWalkGroup);
        }

        // DELETE: api/HomeWalkGroup/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeWalkGroup(int id)
        {
            var homeWalkGroup = await _context.HomeWalkGroups.FindAsync(id);
            if (homeWalkGroup == null)
            {
                return NotFound();
            }

            _context.HomeWalkGroups.Remove(homeWalkGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomeWalkGroupExists(int id)
        {
            return _context.HomeWalkGroups.Any(e => e.Id == id);
        }
    }
}
