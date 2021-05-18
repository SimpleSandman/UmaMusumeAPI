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
    public class CraneGamePrizeFaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGamePrizeFaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGamePrizeFace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGamePrizeFace>>> GetCraneGamePrizeFaces()
        {
            return await _context.CraneGamePrizeFaces.ToListAsync();
        }

        // GET: api/CraneGamePrizeFace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGamePrizeFace>> GetCraneGamePrizeFace(int id)
        {
            var craneGamePrizeFace = await _context.CraneGamePrizeFaces.FindAsync(id);

            if (craneGamePrizeFace == null)
            {
                return NotFound();
            }

            return craneGamePrizeFace;
        }
    }
}
