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
    public class RandomEarTailMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RandomEarTailMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RandomEarTailMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RandomEarTailMotion>>> GetRandomEarTailMotions()
        {
            return await _context.RandomEarTailMotions.ToListAsync();
        }

        // GET: api/RandomEarTailMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RandomEarTailMotion>> GetRandomEarTailMotion(int id)
        {
            var randomEarTailMotion = await _context.RandomEarTailMotions.FindAsync(id);

            if (randomEarTailMotion == null)
            {
                return NotFound();
            }

            return randomEarTailMotion;
        }
    }
}
