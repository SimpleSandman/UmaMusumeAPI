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
    public class SingleModeVenusSpiritGroupController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeVenusSpiritGroupController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeVenusSpiritGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeVenusSpiritGroup>>> GetSingleModeVenusSpiritGroup()
        {
            return await _context.SingleModeVenusSpiritGroups.ToListAsync();
        }

        // GET: api/SingleModeVenusSpiritGroup/5
        [HttpGet("{fanRaidId}")]
        public async Task<ActionResult<SingleModeVenusSpiritGroup>> GetSingleModeVenusSpiritGroup(int spiritId)
        {
            var SingleModeVenusSpiritGroup = await _context.SingleModeVenusSpiritGroups.FindAsync(spiritId);

            if (SingleModeVenusSpiritGroup == null)
            {
                return NotFound();
            }

            return SingleModeVenusSpiritGroup;
        }
    }
}
