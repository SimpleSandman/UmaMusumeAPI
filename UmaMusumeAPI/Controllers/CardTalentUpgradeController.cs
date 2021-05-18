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
    public class CardTalentUpgradeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CardTalentUpgradeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CardTalentUpgrade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardTalentUpgrade>>> GetCardTalentUpgrades()
        {
            return await _context.CardTalentUpgrades.ToListAsync();
        }

        // GET: api/CardTalentUpgrade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardTalentUpgrade>> GetCardTalentUpgrade(int id)
        {
            var cardTalentUpgrade = await _context.CardTalentUpgrades.FindAsync(id);

            if (cardTalentUpgrade == null)
            {
                return NotFound();
            }

            return cardTalentUpgrade;
        }

        // PUT: api/CardTalentUpgrade/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardTalentUpgrade(int id, CardTalentUpgrade cardTalentUpgrade)
        {
            if (id != cardTalentUpgrade.Id)
            {
                return BadRequest();
            }

            _context.Entry(cardTalentUpgrade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardTalentUpgradeExists(id))
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

        // POST: api/CardTalentUpgrade
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CardTalentUpgrade>> PostCardTalentUpgrade(CardTalentUpgrade cardTalentUpgrade)
        {
            _context.CardTalentUpgrades.Add(cardTalentUpgrade);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CardTalentUpgradeExists(cardTalentUpgrade.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCardTalentUpgrade", new { id = cardTalentUpgrade.Id }, cardTalentUpgrade);
        }

        // DELETE: api/CardTalentUpgrade/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardTalentUpgrade(int id)
        {
            var cardTalentUpgrade = await _context.CardTalentUpgrades.FindAsync(id);
            if (cardTalentUpgrade == null)
            {
                return NotFound();
            }

            _context.CardTalentUpgrades.Remove(cardTalentUpgrade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardTalentUpgradeExists(int id)
        {
            return _context.CardTalentUpgrades.Any(e => e.Id == id);
        }
    }
}
