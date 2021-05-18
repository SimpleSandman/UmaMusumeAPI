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
    public class SuccessionFactorEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionFactorEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionFactorEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionFactorEffect>>> GetSuccessionFactorEffects()
        {
            return await _context.SuccessionFactorEffects.ToListAsync();
        }

        // GET: api/SuccessionFactorEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionFactorEffect>> GetSuccessionFactorEffect(int id)
        {
            var successionFactorEffect = await _context.SuccessionFactorEffects.FindAsync(id);

            if (successionFactorEffect == null)
            {
                return NotFound();
            }

            return successionFactorEffect;
        }
    }
}
