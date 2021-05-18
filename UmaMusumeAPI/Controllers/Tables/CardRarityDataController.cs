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
    public class CardRarityDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CardRarityDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CardRarityData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardRarityData>>> GetCardRarityData()
        {
            return await _context.CardRarityData.ToListAsync();
        }

        // GET: api/CardRarityData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardRarityData>> GetCardRarityData(int id)
        {
            var cardRarityData = await _context.CardRarityData.FindAsync(id);

            if (cardRarityData == null)
            {
                return NotFound();
            }

            return cardRarityData;
        }

        // PUT: api/CardRarityData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardRarityData(int id, CardRarityData cardRarityData)
        {
            if (id != cardRarityData.Id)
            {
                return BadRequest();
            }

            _context.Entry(cardRarityData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardRarityDataExists(id))
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

        // POST: api/CardRarityData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CardRarityData>> PostCardRarityData(CardRarityData cardRarityData)
        {
            _context.CardRarityData.Add(cardRarityData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CardRarityDataExists(cardRarityData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCardRarityData", new { id = cardRarityData.Id }, cardRarityData);
        }

        // DELETE: api/CardRarityData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardRarityData(int id)
        {
            var cardRarityData = await _context.CardRarityData.FindAsync(id);
            if (cardRarityData == null)
            {
                return NotFound();
            }

            _context.CardRarityData.Remove(cardRarityData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardRarityDataExists(int id)
        {
            return _context.CardRarityData.Any(e => e.Id == id);
        }
    }
}
