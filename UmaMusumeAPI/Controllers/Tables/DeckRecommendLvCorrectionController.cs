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
    public class DeckRecommendLvCorrectionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DeckRecommendLvCorrectionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DeckRecommendLvCorrection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeckRecommendLvCorrection>>> GetDeckRecommendLvCorrections()
        {
            return await _context.DeckRecommendLvCorrections.ToListAsync();
        }

        // GET: api/DeckRecommendLvCorrection/5
        [HttpGet("{conditionType}")]
        public async Task<ActionResult<DeckRecommendLvCorrection>> GetDeckRecommendLvCorrection(int conditionType)
        {
            var deckRecommendLvCorrection = await _context.DeckRecommendLvCorrections.FindAsync(conditionType);

            if (deckRecommendLvCorrection == null)
            {
                return NotFound();
            }

            return deckRecommendLvCorrection;
        }
    }
}
