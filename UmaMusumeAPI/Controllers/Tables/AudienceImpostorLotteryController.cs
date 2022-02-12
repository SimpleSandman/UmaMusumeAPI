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
    public class AudienceImpostorLotteryController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudienceImpostorLotteryController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudienceImpostorLottery
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudienceImpostorLottery>>> GetAudienceImpostorLottery()
        {
            return await _context.AudienceImpostorLotteries.ToListAsync();
        }

        // GET: api/AudienceImpostorLottery/5
        [HttpGet("{groupId}")]
        public async Task<ActionResult<IEnumerable<AudienceImpostorLottery>>> GetAudienceImpostorLottery(int groupId)
        {
            var audienceImpostorLotteries = await _context.AudienceImpostorLotteries
                .Where(c => c.GroupId == groupId)
                .ToListAsync();

            if (audienceImpostorLotteries == null)
            {
                return NotFound();
            }

            return audienceImpostorLotteries;
        }
    }
}
