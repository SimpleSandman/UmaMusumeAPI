using System.Collections.Generic;
using System.Linq;
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
        public async Task<ActionResult<IEnumerable<BasicMissionDataInfo>>> GetBasicMissionDataInfo(int missionId)
        {
            var basicMissionDataInfo = await _context.BasicMissionDataInfos
                .Where(c => c.MissionId == missionId)
                .ToListAsync();

            if (basicMissionDataInfo == null)
            {
                return NotFound();
            }

            return basicMissionDataInfo;
        }
    }
}
