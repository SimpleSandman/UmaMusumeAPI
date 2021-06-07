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
    public class BasicTeamStadiumScoreBonusInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicTeamStadiumScoreBonusInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicTeamStadiumScoreBonusInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicTeamStadiumScoreBonusInfo>>> GetBasicTeamStadiumScoreBonusInfos()
        {
            return await _context.BasicTeamStadiumScoreBonusInfos.ToListAsync();
        }

        // GET: api/BasicTeamStadiumScoreBonusInfo/5
        [HttpGet("{teamStadiumScoreBonusId}")]
        public async Task<ActionResult<BasicTeamStadiumScoreBonusInfo>> GetBasicTeamStadiumScoreBonusInfo(int teamStadiumScoreBonusId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicTeamStadiumScoreBonusInfo = await _context.BasicTeamStadiumScoreBonusInfos.SingleOrDefaultAsync(c => c.TeamStadiumScoreBonusId == teamStadiumScoreBonusId);

            if (basicTeamStadiumScoreBonusInfo == null)
            {
                return NotFound();
            }

            return basicTeamStadiumScoreBonusInfo;
        }
    }
}
