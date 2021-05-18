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
    public class CraneGameArmSwingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameArmSwingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameArmSwing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameArmSwing>>> GetCraneGameArmSwings()
        {
            return await _context.CraneGameArmSwings.ToListAsync();
        }

        // GET: api/CraneGameArmSwing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameArmSwing>> GetCraneGameArmSwing(int id)
        {
            var craneGameArmSwing = await _context.CraneGameArmSwings.FindAsync(id);

            if (craneGameArmSwing == null)
            {
                return NotFound();
            }

            return craneGameArmSwing;
        }
    }
}
