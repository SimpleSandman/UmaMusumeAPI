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
    public class AnnounceSupportCardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AnnounceSupportCardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AnnounceSupportCard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnounceSupportCard>>> GetAnnounceSupportCards()
        {
            return await _context.AnnounceSupportCards.ToListAsync();
        }

        // GET: api/AnnounceSupportCard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnounceSupportCard>> GetAnnounceSupportCard(int id)
        {
            var announceSupportCard = await _context.AnnounceSupportCards.FindAsync(id);

            if (announceSupportCard == null)
            {
                return NotFound();
            }

            return announceSupportCard;
        }

        // PUT: api/AnnounceSupportCard/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnnounceSupportCard(int id, AnnounceSupportCard announceSupportCard)
        {
            if (id != announceSupportCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(announceSupportCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnnounceSupportCardExists(id))
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

        // POST: api/AnnounceSupportCard
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnnounceSupportCard>> PostAnnounceSupportCard(AnnounceSupportCard announceSupportCard)
        {
            _context.AnnounceSupportCards.Add(announceSupportCard);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnnounceSupportCardExists(announceSupportCard.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnnounceSupportCard", new { id = announceSupportCard.Id }, announceSupportCard);
        }

        // DELETE: api/AnnounceSupportCard/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnnounceSupportCard(int id)
        {
            var announceSupportCard = await _context.AnnounceSupportCards.FindAsync(id);
            if (announceSupportCard == null)
            {
                return NotFound();
            }

            _context.AnnounceSupportCards.Remove(announceSupportCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnnounceSupportCardExists(int id)
        {
            return _context.AnnounceSupportCards.Any(e => e.Id == id);
        }
    }
}
