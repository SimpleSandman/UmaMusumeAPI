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
    public class JukeboxCommentController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public JukeboxCommentController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/JukeboxComment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JukeboxComment>>> GetJukeboxComments()
        {
            return await _context.JukeboxComments.ToListAsync();
        }

        // GET: api/JukeboxComment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JukeboxComment>> GetJukeboxComment(int id)
        {
            var jukeboxComment = await _context.JukeboxComments.FindAsync(id);

            if (jukeboxComment == null)
            {
                return NotFound();
            }

            return jukeboxComment;
        }
    }
}
