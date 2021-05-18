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
    public class SingleModeRaceLiveController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRaceLiveController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRaceLive
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRaceLive>>> GetSingleModeRaceLives()
        {
            return await _context.SingleModeRaceLives.ToListAsync();
        }

        // GET: api/SingleModeRaceLive/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRaceLive>> GetSingleModeRaceLive(int id)
        {
            var singleModeRaceLive = await _context.SingleModeRaceLives.FindAsync(id);

            if (singleModeRaceLive == null)
            {
                return NotFound();
            }

            return singleModeRaceLive;
        }
    }
}
