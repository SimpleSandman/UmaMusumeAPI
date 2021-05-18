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
    public class RaceJikkyoCommentController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoCommentController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoComment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoComment>>> GetRaceJikkyoComments()
        {
            return await _context.RaceJikkyoComments.ToListAsync();
        }

        // GET: api/RaceJikkyoComment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoComment>> GetRaceJikkyoComment(int id)
        {
            var raceJikkyoComment = await _context.RaceJikkyoComments.FindAsync(id);

            if (raceJikkyoComment == null)
            {
                return NotFound();
            }

            return raceJikkyoComment;
        }
    }
}
