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
    public class SuccessionInitialFactorController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionInitialFactorController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionInitialFactor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionInitialFactor>>> GetSuccessionInitialFactors()
        {
            return await _context.SuccessionInitialFactors.ToListAsync();
        }

        // GET: api/SuccessionInitialFactor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionInitialFactor>> GetSuccessionInitialFactor(int id)
        {
            var successionInitialFactor = await _context.SuccessionInitialFactors.FindAsync(id);

            if (successionInitialFactor == null)
            {
                return NotFound();
            }

            return successionInitialFactor;
        }
    }
}
