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
    public class HomePropSettingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomePropSettingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomePropSetting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomePropSetting>>> GetHomePropSettings()
        {
            return await _context.HomePropSettings.ToListAsync();
        }

        // GET: api/HomePropSetting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomePropSetting>> GetHomePropSetting(int id)
        {
            var homePropSetting = await _context.HomePropSettings.FindAsync(id);

            if (homePropSetting == null)
            {
                return NotFound();
            }

            return homePropSetting;
        }

        // PUT: api/HomePropSetting/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomePropSetting(int id, HomePropSetting homePropSetting)
        {
            if (id != homePropSetting.PosId)
            {
                return BadRequest();
            }

            _context.Entry(homePropSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomePropSettingExists(id))
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

        // POST: api/HomePropSetting
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HomePropSetting>> PostHomePropSetting(HomePropSetting homePropSetting)
        {
            _context.HomePropSettings.Add(homePropSetting);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HomePropSettingExists(homePropSetting.PosId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHomePropSetting", new { id = homePropSetting.PosId }, homePropSetting);
        }

        // DELETE: api/HomePropSetting/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomePropSetting(int id)
        {
            var homePropSetting = await _context.HomePropSettings.FindAsync(id);
            if (homePropSetting == null)
            {
                return NotFound();
            }

            _context.HomePropSettings.Remove(homePropSetting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomePropSettingExists(int id)
        {
            return _context.HomePropSettings.Any(e => e.PosId == id);
        }
    }
}
