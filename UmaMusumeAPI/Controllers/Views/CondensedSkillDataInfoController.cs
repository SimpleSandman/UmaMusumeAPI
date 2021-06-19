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
    public class CondensedSkillDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CondensedSkillDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CondensedSkillDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CondensedSkillDataInfo>>> GetCondensedSkillDataInfos()
        {
            return await _context.CondensedSkillDataInfos.ToListAsync();
        }

        // GET: api/CondensedSkillDataInfo/5
        [HttpGet("{skillId}")]
        public async Task<ActionResult<CondensedSkillDataInfo>> GetCondensedSkillDataInfo(int skillId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var condensedSkillDataInfo = await _context.CondensedSkillDataInfos.SingleOrDefaultAsync(c => c.SkillId == skillId);

            if (condensedSkillDataInfo == null)
            {
                return NotFound();
            }

            return condensedSkillDataInfo;
        }
    }
}
