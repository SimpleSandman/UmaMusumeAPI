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
    public class HomeEnvSettingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeEnvSettingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeEnvSetting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeEnvSetting>>> GetHomeEnvSettings()
        {
            return await _context.HomeEnvSettings.ToListAsync();
        }

        // GET: api/HomeEnvSetting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeEnvSetting>> GetHomeEnvSetting(int id)
        {
            var homeEnvSetting = await _context.HomeEnvSettings.FindAsync(id);

            if (homeEnvSetting == null)
            {
                return NotFound();
            }

            return homeEnvSetting;
        }

        // PUT: api/HomeEnvSetting/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomeEnvSetting(int id, HomeEnvSetting homeEnvSetting)
        {
            if (id != homeEnvSetting.Id)
            {
                return BadRequest();
            }

            _context.Entry(homeEnvSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomeEnvSettingExists(id))
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

        // POST: api/HomeEnvSetting
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HomeEnvSetting>> PostHomeEnvSetting(HomeEnvSetting homeEnvSetting)
        {
            _context.HomeEnvSettings.Add(homeEnvSetting);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HomeEnvSettingExists(homeEnvSetting.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHomeEnvSetting", new { id = homeEnvSetting.Id }, homeEnvSetting);
        }

        // DELETE: api/HomeEnvSetting/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeEnvSetting(int id)
        {
            var homeEnvSetting = await _context.HomeEnvSettings.FindAsync(id);
            if (homeEnvSetting == null)
            {
                return NotFound();
            }

            _context.HomeEnvSettings.Remove(homeEnvSetting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomeEnvSettingExists(int id)
        {
            return _context.HomeEnvSettings.Any(e => e.Id == id);
        }
    }
}
