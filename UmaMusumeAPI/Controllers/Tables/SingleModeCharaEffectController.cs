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
    public class SingleModeCharaEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCharaEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCharaEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCharaEffect>>> GetSingleModeCharaEffects()
        {
            return await _context.SingleModeCharaEffects.ToListAsync();
        }

        // GET: api/SingleModeCharaEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeCharaEffect>> GetSingleModeCharaEffect(int id)
        {
            var singleModeCharaEffect = await _context.SingleModeCharaEffects.FindAsync(id);

            if (singleModeCharaEffect == null)
            {
                return NotFound();
            }

            return singleModeCharaEffect;
        }
    }
}
