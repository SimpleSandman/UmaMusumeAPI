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
    public class BasicSingleModeCharaGradeInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicSingleModeCharaGradeInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicSingleModeCharaGradeInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicSingleModeCharaGradeInfo>>> GetBasicSingleModeCharaGradeInfos()
        {
            return await _context.BasicSingleModeCharaGradeInfos.ToListAsync();
        }

        // GET: api/BasicSingleModeCharaGradeInfo/5
        [HttpGet("{singleModeCharaGradeId}")]
        public async Task<ActionResult<BasicSingleModeCharaGradeInfo>> GetBasicSingleModeCharaGradeInfo(int singleModeCharaGradeId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicSingleModeCharaGradeInfo = await _context.BasicSingleModeCharaGradeInfos.SingleOrDefaultAsync(c => c.SingleModeCharaGradeId == singleModeCharaGradeId);

            if (basicSingleModeCharaGradeInfo == null)
            {
                return NotFound();
            }

            return basicSingleModeCharaGradeInfo;
        }
    }
}
