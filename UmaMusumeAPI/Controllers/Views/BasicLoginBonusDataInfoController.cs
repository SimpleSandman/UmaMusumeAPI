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
    public class BasicLoginBonusDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicLoginBonusDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicLoginBonusDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicLoginBonusDataInfo>>> GetBasicLoginBonusDataInfos()
        {
            return await _context.BasicLoginBonusDataInfos.ToListAsync();
        }

        // GET: api/BasicLoginBonusDataInfo/5
        [HttpGet("{loginBonusId}")]
        public async Task<ActionResult<BasicLoginBonusDataInfo>> GetBasicLoginBonusDataInfo(int loginBonusId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicLoginBonusDataInfo = await _context.BasicLoginBonusDataInfos.SingleOrDefaultAsync(c => c.LoginBonusId == loginBonusId);

            if (basicLoginBonusDataInfo == null)
            {
                return NotFound();
            }

            return basicLoginBonusDataInfo;
        }
    }
}
