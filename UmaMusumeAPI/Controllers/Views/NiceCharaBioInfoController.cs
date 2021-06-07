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
    public class NiceCharaBioInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceCharaBioInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceCharaBioInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceCharaBioInfo>>> GetNiceCharaBioInfos()
        {
            return await _context.NiceCharaBioInfos.ToListAsync();
        }

        // GET: api/NiceCharaBioInfo/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<NiceCharaBioInfo>> GetNiceCharaBioInfo(int charaId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceCharaBioInfo = await _context.NiceCharaBioInfos.SingleOrDefaultAsync(c => c.CharaId == charaId);

            if (niceCharaBioInfo == null)
            {
                return NotFound();
            }

            return niceCharaBioInfo;
        }
    }
}
