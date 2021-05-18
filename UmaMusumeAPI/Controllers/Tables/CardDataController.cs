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
    }
}
