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
    public class SingleModeEventProductionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEventProductionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEventProduction
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEventProduction>>> GetSingleModeEventProductions()
        {
            return await _context.SingleModeEventProductions.ToListAsync();
        }

        // GET: api/SingleModeEventProduction/5
        [HttpGet("{storyId}")]
        public async Task<ActionResult<SingleModeEventProduction>> GetSingleModeEventProduction(int storyId)
        {
            var singleModeEventProduction = await _context.SingleModeEventProductions.FindAsync(storyId);

            if (singleModeEventProduction == null)
            {
                return NotFound();
            }

            return singleModeEventProduction;
        }
    }
}
