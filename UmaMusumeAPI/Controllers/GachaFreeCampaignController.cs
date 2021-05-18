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
    public class GachaFreeCampaignController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaFreeCampaignController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaFreeCampaign
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaFreeCampaign>>> GetGachaFreeCampaigns()
        {
            return await _context.GachaFreeCampaigns.ToListAsync();
        }

        // GET: api/GachaFreeCampaign/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaFreeCampaign>> GetGachaFreeCampaign(int id)
        {
            var gachaFreeCampaign = await _context.GachaFreeCampaigns.FindAsync(id);

            if (gachaFreeCampaign == null)
            {
                return NotFound();
            }

            return gachaFreeCampaign;
        }

        // PUT: api/GachaFreeCampaign/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGachaFreeCampaign(int id, GachaFreeCampaign gachaFreeCampaign)
        {
            if (id != gachaFreeCampaign.Id)
            {
                return BadRequest();
            }

            _context.Entry(gachaFreeCampaign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GachaFreeCampaignExists(id))
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

        // POST: api/GachaFreeCampaign
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GachaFreeCampaign>> PostGachaFreeCampaign(GachaFreeCampaign gachaFreeCampaign)
        {
            _context.GachaFreeCampaigns.Add(gachaFreeCampaign);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GachaFreeCampaignExists(gachaFreeCampaign.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGachaFreeCampaign", new { id = gachaFreeCampaign.Id }, gachaFreeCampaign);
        }

        // DELETE: api/GachaFreeCampaign/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGachaFreeCampaign(int id)
        {
            var gachaFreeCampaign = await _context.GachaFreeCampaigns.FindAsync(id);
            if (gachaFreeCampaign == null)
            {
                return NotFound();
            }

            _context.GachaFreeCampaigns.Remove(gachaFreeCampaign);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GachaFreeCampaignExists(int id)
        {
            return _context.GachaFreeCampaigns.Any(e => e.Id == id);
        }
    }
}
