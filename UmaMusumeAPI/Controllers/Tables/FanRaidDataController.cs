using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class FanRaidDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public FanRaidDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/FanRaidData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FanRaidData>>> GetFanRaidData()
        {
            return await _context.FanRaidData.ToListAsync();
        }

        // GET: api/FanRaidData/5
        [HttpGet("{fanRaidId}")]
        public async Task<ActionResult<FanRaidData>> GetFanRaidData(int fanRaidId)
        {
            var fanRaidData = await _context.FanRaidData.FindAsync(fanRaidId);

            if (fanRaidData == null)
            {
                return NotFound();
            }

            return fanRaidData;
        }
    }
}
