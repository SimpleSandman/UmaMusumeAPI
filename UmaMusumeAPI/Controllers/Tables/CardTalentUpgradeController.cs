using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
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
    }
}
