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
    public class MiniMouthTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniMouthTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniMouthType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniMouthType>>> GetMiniMouthTypes()
        {
            return await _context.MiniMouthTypes.ToListAsync();
        }

        // GET: api/MiniMouthType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniMouthType>> GetMiniMouthType(int id)
        {
            var miniMouthType = await _context.MiniMouthTypes.FindAsync(id);

            if (miniMouthType == null)
            {
                return NotFound();
            }

            return miniMouthType;
        }
    }
}
