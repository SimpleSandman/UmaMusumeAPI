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
    public class SingleModeProgramController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeProgramController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeProgram
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeProgram>>> GetSingleModePrograms()
        {
            return await _context.SingleModePrograms.ToListAsync();
        }

        // GET: api/SingleModeProgram/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeProgram>> GetSingleModeProgram(int id)
        {
            var singleModeProgram = await _context.SingleModePrograms.FindAsync(id);

            if (singleModeProgram == null)
            {
                return NotFound();
            }

            return singleModeProgram;
        }
    }
}
