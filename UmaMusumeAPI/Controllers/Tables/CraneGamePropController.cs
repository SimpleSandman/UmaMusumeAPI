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
    public class CraneGamePropController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGamePropController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameProp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameProp>>> GetCraneGameProps()
        {
            return await _context.CraneGameProps.ToListAsync();
        }

        // GET: api/CraneGameProp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameProp>> GetCraneGameProp(int id)
        {
            var craneGameProp = await _context.CraneGameProps.FindAsync(id);

            if (craneGameProp == null)
            {
                return NotFound();
            }

            return craneGameProp;
        }
    }
}
