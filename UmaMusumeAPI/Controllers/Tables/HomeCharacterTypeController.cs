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
    public class HomeCharacterTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeCharacterTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeCharacterType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeCharacterType>>> GetHomeCharacterTypes()
        {
            return await _context.HomeCharacterTypes.ToListAsync();
        }

        // GET: api/HomeCharacterType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeCharacterType>> GetHomeCharacterType(int id)
        {
            var homeCharacterType = await _context.HomeCharacterTypes.FindAsync(id);

            if (homeCharacterType == null)
            {
                return NotFound();
            }

            return homeCharacterType;
        }

        // PUT: api/HomeCharacterType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomeCharacterType(int id, HomeCharacterType homeCharacterType)
        {
            if (id != homeCharacterType.PosId)
            {
                return BadRequest();
            }

            _context.Entry(homeCharacterType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomeCharacterTypeExists(id))
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

        // POST: api/HomeCharacterType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HomeCharacterType>> PostHomeCharacterType(HomeCharacterType homeCharacterType)
        {
            _context.HomeCharacterTypes.Add(homeCharacterType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HomeCharacterTypeExists(homeCharacterType.PosId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHomeCharacterType", new { id = homeCharacterType.PosId }, homeCharacterType);
        }

        // DELETE: api/HomeCharacterType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeCharacterType(int id)
        {
            var homeCharacterType = await _context.HomeCharacterTypes.FindAsync(id);
            if (homeCharacterType == null)
            {
                return NotFound();
            }

            _context.HomeCharacterTypes.Remove(homeCharacterType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomeCharacterTypeExists(int id)
        {
            return _context.HomeCharacterTypes.Any(e => e.PosId == id);
        }
    }
}
