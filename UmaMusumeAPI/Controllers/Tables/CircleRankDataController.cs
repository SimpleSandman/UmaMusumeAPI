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
    public class CircleRankDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CircleRankDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CircleRankData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CircleRankData>>> GetCircleRankData()
        {
            return await _context.CircleRankData.ToListAsync();
        }

        // GET: api/CircleRankData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CircleRankData>> GetCircleRankData(int id)
        {
            var circleRankData = await _context.CircleRankData.FindAsync(id);

            if (circleRankData == null)
            {
                return NotFound();
            }

            return circleRankData;
        }
    }
}
