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
    public class SingleModeTrainingEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTrainingEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTrainingEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTrainingEffect>>> GetSingleModeTrainingEffects()
        {
            return await _context.SingleModeTrainingEffects.ToListAsync();
        }

        // GET: api/SingleModeTrainingEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTrainingEffect>> GetSingleModeTrainingEffect(int id)
        {
            var singleModeTrainingEffect = await _context.SingleModeTrainingEffects.FindAsync(id);

            if (singleModeTrainingEffect == null)
            {
                return NotFound();
            }

            return singleModeTrainingEffect;
        }
    }
}
