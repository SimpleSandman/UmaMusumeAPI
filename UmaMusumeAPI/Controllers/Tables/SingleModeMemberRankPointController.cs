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
    public class SingleModeMemberRankPointController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeMemberRankPointController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeMemberRankPoint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeMemberRankPoint>>> GetSingleModeMemberRankPoints()
        {
            return await _context.SingleModeMemberRankPoints.ToListAsync();
        }

        // GET: api/SingleModeMemberRankPoint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeMemberRankPoint>> GetSingleModeMemberRankPoint(int id)
        {
            var singleModeMemberRankPoint = await _context.SingleModeMemberRankPoints.FindAsync(id);

            if (singleModeMemberRankPoint == null)
            {
                return NotFound();
            }

            return singleModeMemberRankPoint;
        }
    }
}
