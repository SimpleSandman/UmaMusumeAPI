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
    public class SingleModeCharaProgramController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCharaProgramController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCharaProgram
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCharaProgram>>> GetSingleModeCharaPrograms()
        {
            return await _context.SingleModeCharaPrograms.ToListAsync();
        }

        // GET: api/SingleModeCharaProgram/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeCharaProgram>> GetSingleModeCharaProgram(int id)
        {
            var singleModeCharaProgram = await _context.SingleModeCharaPrograms.FindAsync(id);

            if (singleModeCharaProgram == null)
            {
                return NotFound();
            }

            return singleModeCharaProgram;
        }
    }
}
