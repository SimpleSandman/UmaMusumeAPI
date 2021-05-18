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
    }
}
