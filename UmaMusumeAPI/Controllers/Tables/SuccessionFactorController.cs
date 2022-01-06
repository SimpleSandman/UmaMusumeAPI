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
    public class SuccessionFactorController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionFactorController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionFactor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionFactor>>> GetSuccessionFactors()
        {
            return await _context.SuccessionFactors.ToListAsync();
        }

        // GET: api/SuccessionFactor/5
        [HttpGet("{factorId}")]
        public async Task<ActionResult<SuccessionFactor>> GetSuccessionFactor(int factorId)
        {
            var successionFactor = await _context.SuccessionFactors.FindAsync(factorId);

            if (successionFactor == null)
            {
                return NotFound();
            }

            return successionFactor;
        }
    }
}
