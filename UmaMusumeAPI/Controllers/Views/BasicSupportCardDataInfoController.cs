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
    public class BasicSupportCardDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicSupportCardDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicSupportCardDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicSupportCardDataInfo>>> GetBasicSupportCardDataInfos()
        {
            return await _context.BasicSupportCardDataInfos.ToListAsync();
        }

        // GET: api/BasicSupportCardDataInfo/5
        [HttpGet("{supportCardId}")]
        public async Task<ActionResult<BasicSupportCardDataInfo>> GetBasicSupportCardDataInfo(int supportCardId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicSupportCardDataInfo = await _context.BasicSupportCardDataInfos.SingleOrDefaultAsync(c => c.SupportCardId == supportCardId);

            if (basicSupportCardDataInfo == null)
            {
                return NotFound();
            }

            return basicSupportCardDataInfo;
        }
    }
}
