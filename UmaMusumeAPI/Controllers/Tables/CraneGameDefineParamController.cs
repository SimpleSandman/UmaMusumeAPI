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
    public class CraneGameDefineParamController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameDefineParamController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameDefineParam
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameDefineParam>>> GetCraneGameDefineParams()
        {
            return await _context.CraneGameDefineParams.ToListAsync();
        }

        // GET: api/CraneGameDefineParam/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameDefineParam>> GetCraneGameDefineParam(int id)
        {
            var craneGameDefineParam = await _context.CraneGameDefineParams.FindAsync(id);

            if (craneGameDefineParam == null)
            {
                return NotFound();
            }

            return craneGameDefineParam;
        }
    }
}
