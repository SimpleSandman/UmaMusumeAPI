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
    public class NiceSkillDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceSkillDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceSkillDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceSkillDataInfo>>> GetNiceSkillDataInfos()
        {
            return await _context.NiceSkillDataInfos.ToListAsync();
        }

        // GET: api/NiceSkillDataInfo/5
        [HttpGet("{skillId}")]
        public async Task<ActionResult<IEnumerable<NiceSkillDataInfo>>> GetNiceSkillDataInfo(int skillId)
        {
            var niceSkillDataInfo = await _context.NiceSkillDataInfos
                .Where(c => c.SkillId == skillId)
                .ToListAsync();

            if (niceSkillDataInfo == null)
            {
                return NotFound();
            }

            return niceSkillDataInfo;
        }
    }
}
