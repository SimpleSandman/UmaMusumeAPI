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
    public class BannerDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BannerDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BannerData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BannerData>>> GetBannerData()
        {
            return await _context.BannerData.ToListAsync();
        }

        // GET: api/BannerData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BannerData>> GetBannerData(int id)
        {
            var bannerData = await _context.BannerData.FindAsync(id);

            if (bannerData == null)
            {
                return NotFound();
            }

            return bannerData;
        }

        // PUT: api/BannerData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBannerData(int id, BannerData bannerData)
        {
            if (id != bannerData.Id)
            {
                return BadRequest();
            }

            _context.Entry(bannerData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BannerDataExists(id))
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

        // POST: api/BannerData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BannerData>> PostBannerData(BannerData bannerData)
        {
            _context.BannerData.Add(bannerData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BannerDataExists(bannerData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBannerData", new { id = bannerData.Id }, bannerData);
        }

        // DELETE: api/BannerData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBannerData(int id)
        {
            var bannerData = await _context.BannerData.FindAsync(id);
            if (bannerData == null)
            {
                return NotFound();
            }

            _context.BannerData.Remove(bannerData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BannerDataExists(int id)
        {
            return _context.BannerData.Any(e => e.Id == id);
        }
    }
}
