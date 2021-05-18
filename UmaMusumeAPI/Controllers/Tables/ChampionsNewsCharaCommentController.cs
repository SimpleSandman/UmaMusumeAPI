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
    public class ChampionsNewsCharaCommentController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsCharaCommentController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsCharaComment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsCharaComment>>> GetChampionsNewsCharaComments()
        {
            return await _context.ChampionsNewsCharaComments.ToListAsync();
        }

        // GET: api/ChampionsNewsCharaComment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsCharaComment>> GetChampionsNewsCharaComment(int id)
        {
            var championsNewsCharaComment = await _context.ChampionsNewsCharaComments.FindAsync(id);

            if (championsNewsCharaComment == null)
            {
                return NotFound();
            }

            return championsNewsCharaComment;
        }
    }
}
