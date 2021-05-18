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
    public class GiftMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GiftMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GiftMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GiftMessage>>> GetGiftMessages()
        {
            return await _context.GiftMessages.ToListAsync();
        }

        // GET: api/GiftMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GiftMessage>> GetGiftMessage(int id)
        {
            var giftMessage = await _context.GiftMessages.FindAsync(id);

            if (giftMessage == null)
            {
                return NotFound();
            }

            return giftMessage;
        }

        // PUT: api/GiftMessage/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGiftMessage(int id, GiftMessage giftMessage)
        {
            if (id != giftMessage.Id)
            {
                return BadRequest();
            }

            _context.Entry(giftMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GiftMessageExists(id))
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

        // POST: api/GiftMessage
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GiftMessage>> PostGiftMessage(GiftMessage giftMessage)
        {
            _context.GiftMessages.Add(giftMessage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GiftMessageExists(giftMessage.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGiftMessage", new { id = giftMessage.Id }, giftMessage);
        }

        // DELETE: api/GiftMessage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGiftMessage(int id)
        {
            var giftMessage = await _context.GiftMessages.FindAsync(id);
            if (giftMessage == null)
            {
                return NotFound();
            }

            _context.GiftMessages.Remove(giftMessage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GiftMessageExists(int id)
        {
            return _context.GiftMessages.Any(e => e.Id == id);
        }
    }
}
