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
    public class CardDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CardDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CardData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardData>>> GetCardData()
        {
            return await _context.CardData.ToListAsync();
        }

        // GET: api/CardData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardData>> GetCardData(int id)
        {
            var cardData = await _context.CardData.FindAsync(id);

            if (cardData == null)
            {
                return NotFound();
            }

            return cardData;
        }

        // PUT: api/CardData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardData(int id, CardData cardData)
        {
            if (id != cardData.Id)
            {
                return BadRequest();
            }

            _context.Entry(cardData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardDataExists(id))
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

        // POST: api/CardData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CardData>> PostCardData(CardData cardData)
        {
            _context.CardData.Add(cardData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CardDataExists(cardData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCardData", new { id = cardData.Id }, cardData);
        }

        // DELETE: api/CardData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardData(int id)
        {
            var cardData = await _context.CardData.FindAsync(id);
            if (cardData == null)
            {
                return NotFound();
            }

            _context.CardData.Remove(cardData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardDataExists(int id)
        {
            return _context.CardData.Any(e => e.Id == id);
        }
    }
}
