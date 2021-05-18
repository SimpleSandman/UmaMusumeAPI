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
    public class CampaignDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CampaignDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CampaignData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignData>>> GetCampaignData()
        {
            return await _context.CampaignData.ToListAsync();
        }

        // GET: api/CampaignData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignData>> GetCampaignData(int id)
        {
            var campaignData = await _context.CampaignData.FindAsync(id);

            if (campaignData == null)
            {
                return NotFound();
            }

            return campaignData;
        }

        // PUT: api/CampaignData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampaignData(int id, CampaignData campaignData)
        {
            if (id != campaignData.CampaignId)
            {
                return BadRequest();
            }

            _context.Entry(campaignData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignDataExists(id))
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

        // POST: api/CampaignData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CampaignData>> PostCampaignData(CampaignData campaignData)
        {
            _context.CampaignData.Add(campaignData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CampaignDataExists(campaignData.CampaignId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCampaignData", new { id = campaignData.CampaignId }, campaignData);
        }

        // DELETE: api/CampaignData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampaignData(int id)
        {
            var campaignData = await _context.CampaignData.FindAsync(id);
            if (campaignData == null)
            {
                return NotFound();
            }

            _context.CampaignData.Remove(campaignData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CampaignDataExists(int id)
        {
            return _context.CampaignData.Any(e => e.CampaignId == id);
        }
    }
}
