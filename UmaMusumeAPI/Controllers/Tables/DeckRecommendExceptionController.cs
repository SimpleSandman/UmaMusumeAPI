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
    public class DeckRecommendExceptionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DeckRecommendExceptionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DeckRecommendException
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeckRecommendException>>> GetDeckRecommendExceptions()
        {
            return await _context.DeckRecommendExceptions.ToListAsync();
        }

        // GET: api/DeckRecommendException/5
        [HttpGet("{supportCardId}")]
        public async Task<ActionResult<DeckRecommendException>> GetDeckRecommendException(int supportCardId)
        {
            var deckRecommendException = await _context.DeckRecommendExceptions.FindAsync(supportCardId);

            if (deckRecommendException == null)
            {
                return NotFound();
            }

            return deckRecommendException;
        }
    }
}
