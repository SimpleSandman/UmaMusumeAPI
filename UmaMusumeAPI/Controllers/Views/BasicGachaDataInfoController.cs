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
    public class BasicGachaDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicGachaDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicGachaDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicGachaDataInfo>>> GetBasicGachaDataInfos()
        {
            return await _context.BasicGachaDataInfos.ToListAsync();
        }

        // GET: api/BasicGachaDataInfo/5
        [HttpGet("{gachaId}")]
        public async Task<ActionResult<BasicGachaDataInfo>> GetBasicGachaDataInfo(int gachaId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicGachaDataInfo = await _context.BasicGachaDataInfos.SingleOrDefaultAsync(c => c.GachaId == gachaId);

            if (basicGachaDataInfo == null)
            {
                return NotFound();
            }

            return basicGachaDataInfo;
        }
    }
}
