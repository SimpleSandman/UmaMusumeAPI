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
    public class SupportCardUniqueEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardUniqueEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardUniqueEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardUniqueEffect>>> GetSupportCardUniqueEffects()
        {
            return await _context.SupportCardUniqueEffects.ToListAsync();
        }

        // GET: api/SupportCardUniqueEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardUniqueEffect>> GetSupportCardUniqueEffect(int id)
        {
            var supportCardUniqueEffect = await _context.SupportCardUniqueEffects.FindAsync(id);

            if (supportCardUniqueEffect == null)
            {
                return NotFound();
            }

            return supportCardUniqueEffect;
        }
    }
}
