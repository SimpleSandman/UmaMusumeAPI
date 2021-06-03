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
    public class BasicDressDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicDressDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicDressDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicDressDataInfo>>> GetBasicDressDataInfos()
        {
            return await _context.BasicDressDataInfos.ToListAsync();
        }

        // GET: api/BasicDressDataInfo/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<BasicDressDataInfo>> GetBasicDressDataInfo(int dressId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicDressDataInfo = await _context.BasicDressDataInfos.SingleOrDefaultAsync(c => c.DressId == dressId);

            if (basicDressDataInfo == null)
            {
                return NotFound();
            }

            return basicDressDataInfo;
        }
    }
}
