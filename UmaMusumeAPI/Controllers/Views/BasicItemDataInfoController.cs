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
    public class BasicItemDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicItemDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicItemDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicItemDataInfo>>> GetBasicItemDataInfos()
        {
            return await _context.BasicItemDataInfos.ToListAsync();
        }

        // GET: api/BasicItemDataInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasicItemDataInfo>> GetBasicItemDataInfo(int id)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicItemDataInfo = await _context.BasicItemDataInfos.SingleOrDefaultAsync(c => c.ItemId == id);

            if (basicItemDataInfo == null)
            {
                return NotFound();
            }

            return basicItemDataInfo;
        }
    }
}
