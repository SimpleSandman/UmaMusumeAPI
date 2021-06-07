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
    public class BasicRaceInstanceInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicRaceInstanceInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicRaceInstanceInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicRaceInstanceInfo>>> GetBasicRaceInstanceInfos()
        {
            return await _context.BasicRaceInstanceInfos.ToListAsync();
        }

        // GET: api/BasicRaceInstanceInfo/5
        [HttpGet("{raceInstanceId}")]
        public async Task<ActionResult<BasicRaceInstanceInfo>> GetBasicRaceInstanceInfo(int raceInstanceId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicRaceInstanceInfo = await _context.BasicRaceInstanceInfos.SingleOrDefaultAsync(c => c.RaceInstanceId == raceInstanceId);

            if (basicRaceInstanceInfo == null)
            {
                return NotFound();
            }

            return basicRaceInstanceInfo;
        }
    }
}
