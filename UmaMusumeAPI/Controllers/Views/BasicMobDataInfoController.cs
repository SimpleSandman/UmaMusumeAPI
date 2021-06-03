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
    public class BasicMobDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicMobDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicMobDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicMobDataInfo>>> GetBasicMobDataInfos()
        {
            return await _context.BasicMobDataInfos.ToListAsync();
        }

        // GET: api/BasicMobDataInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasicMobDataInfo>> GetBasicMobDataInfo(int id)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicMobDataInfo = await _context.BasicMobDataInfos.SingleOrDefaultAsync(c => c.MobId == id);

            if (basicMobDataInfo == null)
            {
                return NotFound();
            }

            return basicMobDataInfo;
        }
    }
}
