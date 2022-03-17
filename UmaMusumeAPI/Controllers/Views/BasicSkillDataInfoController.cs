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
    public class BasicSkillDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicSkillDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicSkillDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicSkillDataInfo>>> GetBasicSkillDataInfos()
        {
            return await _context.BasicSkillDataInfos.ToListAsync();
        }

        // GET: api/BasicSkillDataInfo/5
        [HttpGet("{skillId}")]
        public async Task<ActionResult<IEnumerable<BasicSkillDataInfo>>> GetBasicSkillDataInfo(int skillId)
        {
            var basicSkillDataInfo = await _context.BasicSkillDataInfos
                .Where(c => c.SkillId == skillId)
                .ToListAsync();

            if (basicSkillDataInfo == null)
            {
                return NotFound();
            }

            return basicSkillDataInfo;
        }
    }
}
