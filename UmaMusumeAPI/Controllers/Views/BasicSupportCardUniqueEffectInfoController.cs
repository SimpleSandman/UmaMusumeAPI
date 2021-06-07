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
    public class BasicSupportCardUniqueEffectInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicSupportCardUniqueEffectInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicSupportCardUniqueEffectInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicSupportCardUniqueEffectInfo>>> GetBasicSupportCardUniqueEffectInfos()
        {
            return await _context.BasicSupportCardUniqueEffectInfos.ToListAsync();
        }

        // GET: api/BasicSupportCardUniqueEffectInfo/5
        [HttpGet("{supportCardUniqueEffectId}")]
        public async Task<ActionResult<BasicSupportCardUniqueEffectInfo>> GetBasicSupportCardUniqueEffectInfo(int supportCardUniqueEffectId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicSupportCardUniqueEffectInfo = await _context.BasicSupportCardUniqueEffectInfos.SingleOrDefaultAsync(c => c.SupportCardUniqueEffectId == supportCardUniqueEffectId);

            if (basicSupportCardUniqueEffectInfo == null)
            {
                return NotFound();
            }

            return basicSupportCardUniqueEffectInfo;
        }
    }
}
