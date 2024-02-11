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
    public class FactorResearchBoxController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public FactorResearchBoxController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/FactorResearchBox
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FactorResearchBox>>> GetFactorResearchBox()
        {
            return await _context.FactorResearchBoxes.ToListAsync();
        }

        // GET: api/FactorResearchBox/5
        [HttpGet("{boxId}")]
        public async Task<ActionResult<FactorResearchBox>> GetFactorResearchBox(int boxId)
        {
            var factorResearchBox = await _context.FactorResearchBoxes.FindAsync(boxId);

            if (factorResearchBox == null)
            {
                return NotFound();
            }

            return factorResearchBox;
        }
    }
}
