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
    public class BasicLiveDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicLiveDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicLiveDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicLiveDataInfo>>> GetBasicLiveDataInfos()
        {
            return await _context.BasicLiveDataInfos.ToListAsync();
        }

        // GET: api/BasicLiveDataInfo/5
        [HttpGet("{musicId}")]
        public async Task<ActionResult<BasicLiveDataInfo>> GetBasicLiveDataInfo(int musicId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicLiveDataInfo = await _context.BasicLiveDataInfos.SingleOrDefaultAsync(c => c.MusicId == musicId);

            if (basicLiveDataInfo == null)
            {
                return NotFound();
            }

            return basicLiveDataInfo;
        }
    }
}
