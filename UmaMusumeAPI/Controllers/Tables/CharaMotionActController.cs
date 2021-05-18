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
    public class CharaMotionActController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaMotionActController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaMotionAct
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaMotionAct>>> GetCharaMotionActs()
        {
            return await _context.CharaMotionActs.ToListAsync();
        }

        // GET: api/CharaMotionAct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaMotionAct>> GetCharaMotionAct(int id)
        {
            var charaMotionAct = await _context.CharaMotionActs.FindAsync(id);

            if (charaMotionAct == null)
            {
                return NotFound();
            }

            return charaMotionAct;
        }
    }
}
