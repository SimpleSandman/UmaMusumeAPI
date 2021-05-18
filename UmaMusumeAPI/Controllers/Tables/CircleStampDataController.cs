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
    public class CircleStampDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CircleStampDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CircleStampData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CircleStampData>>> GetCircleStampData()
        {
            return await _context.CircleStampData.ToListAsync();
        }

        // GET: api/CircleStampData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CircleStampData>> GetCircleStampData(int id)
        {
            var circleStampData = await _context.CircleStampData.FindAsync(id);

            if (circleStampData == null)
            {
                return NotFound();
            }

            return circleStampData;
        }
    }
}
