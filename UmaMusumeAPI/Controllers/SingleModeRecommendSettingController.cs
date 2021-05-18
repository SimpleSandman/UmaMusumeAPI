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
    public class SingleModeRecommendSettingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRecommendSettingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRecommendSetting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRecommendSetting>>> GetSingleModeRecommendSettings()
        {
            return await _context.SingleModeRecommendSettings.ToListAsync();
        }

        // GET: api/SingleModeRecommendSetting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRecommendSetting>> GetSingleModeRecommendSetting(int id)
        {
            var singleModeRecommendSetting = await _context.SingleModeRecommendSettings.FindAsync(id);

            if (singleModeRecommendSetting == null)
            {
                return NotFound();
            }

            return singleModeRecommendSetting;
        }

        // PUT: api/SingleModeRecommendSetting/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRecommendSetting(int id, SingleModeRecommendSetting singleModeRecommendSetting)
        {
            if (id != singleModeRecommendSetting.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRecommendSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRecommendSettingExists(id))
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

        // POST: api/SingleModeRecommendSetting
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRecommendSetting>> PostSingleModeRecommendSetting(SingleModeRecommendSetting singleModeRecommendSetting)
        {
            _context.SingleModeRecommendSettings.Add(singleModeRecommendSetting);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRecommendSettingExists(singleModeRecommendSetting.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRecommendSetting", new { id = singleModeRecommendSetting.Id }, singleModeRecommendSetting);
        }

        // DELETE: api/SingleModeRecommendSetting/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRecommendSetting(int id)
        {
            var singleModeRecommendSetting = await _context.SingleModeRecommendSettings.FindAsync(id);
            if (singleModeRecommendSetting == null)
            {
                return NotFound();
            }

            _context.SingleModeRecommendSettings.Remove(singleModeRecommendSetting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRecommendSettingExists(int id)
        {
            return _context.SingleModeRecommendSettings.Any(e => e.Id == id);
        }
    }
}
