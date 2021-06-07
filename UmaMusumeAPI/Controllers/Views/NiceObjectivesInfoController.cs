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
    public class NiceObjectivesInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceObjectivesInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceObjectivesInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceObjectivesInfo>>> GetNiceObjectivesInfos()
        {
            return await _context.NiceObjectivesInfos.ToListAsync();
        }

        // GET: api/NiceObjectivesInfo/5
        [HttpGet("{routeId}")]
        public async Task<ActionResult<NiceObjectivesInfo>> GetNiceObjectivesInfo(int routeId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceObjectivesInfo = await _context.NiceObjectivesInfos.SingleOrDefaultAsync(c => c.RouteId == routeId);

            if (niceObjectivesInfo == null)
            {
                return NotFound();
            }

            return niceObjectivesInfo;
        }
    }
}
