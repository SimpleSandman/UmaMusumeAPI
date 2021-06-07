using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicRaceInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicRaceInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicRaceInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicRaceInfo>>> GetBasicRaceInfos()
        {
            return await _context.BasicRaceInfos.ToListAsync();
        }

        // GET: api/BasicRaceInfo/5
        [HttpGet("{raceId}")]
        public async Task<ActionResult<BasicRaceInfo>> GetBasicRaceInfo(int raceId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicRaceInfo = await _context.BasicRaceInfos.SingleOrDefaultAsync(c => c.RaceId == raceId);

            if (basicRaceInfo == null)
            {
                return NotFound();
            }

            return basicRaceInfo;
        }
    }
}
