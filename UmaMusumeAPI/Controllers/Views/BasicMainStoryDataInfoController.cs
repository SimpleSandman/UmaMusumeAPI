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
    public class BasicMainStoryDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicMainStoryDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicMainStoryDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicMainStoryDataInfo>>> GetBasicMainStoryDataInfos()
        {
            return await _context.BasicMainStoryDataInfos.ToListAsync();
        }

        // GET: api/BasicMainStoryDataInfo/5
        [HttpGet("{mainStoryId}")]
        public async Task<ActionResult<BasicMainStoryDataInfo>> GetBasicMainStoryDataInfo(int mainStoryId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicMainStoryDataInfo = await _context.BasicMainStoryDataInfos.SingleOrDefaultAsync(c => c.MainStoryId == mainStoryId);

            if (basicMainStoryDataInfo == null)
            {
                return NotFound();
            }

            return basicMainStoryDataInfo;
        }
    }
}
