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
    public class BasicMissionDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicMissionDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicMissionDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicMissionDataInfo>>> GetBasicMissionDataInfos()
        {
            return await _context.BasicMissionDataInfos.ToListAsync();
        }

        // GET: api/BasicMissionDataInfo/5
        [HttpGet("{missionId}")]
        public async Task<ActionResult<BasicMissionDataInfo>> GetBasicMissionDataInfo(int missionId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicMissionDataInfo = await _context.BasicMissionDataInfos.SingleOrDefaultAsync(c => c.MissionId == missionId);

            if (basicMissionDataInfo == null)
            {
                return NotFound();
            }

            return basicMissionDataInfo;
        }
    }
}
