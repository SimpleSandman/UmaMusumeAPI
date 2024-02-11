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
    public class FactorResearchDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public FactorResearchDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/FactorResearchData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FactorResearchData>>> GetFactorResearchData()
        {
            return await _context.FactorResearchData.ToListAsync();
        }

        // GET: api/FactorResearchData/5
        [HttpGet("{factorResearchEventId}")]
        public async Task<ActionResult<FactorResearchData>> GetFactorResearchData(int factorResearchEventId)
        {
            var factorResearchData = await _context.FactorResearchData.FindAsync(factorResearchEventId);

            if (factorResearchData == null)
            {
                return NotFound();
            }

            return factorResearchData;
        }
    }
}
