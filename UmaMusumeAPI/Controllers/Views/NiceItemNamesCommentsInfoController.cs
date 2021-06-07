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
    public class NiceItemNamesCommentsInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceItemNamesCommentsInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceItemNamesCommentsInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceItemNamesCommentsInfo>>> GetNiceItemNamesCommentsInfos()
        {
            return await _context.NiceItemNamesCommentsInfos.ToListAsync();
        }

        // GET: api/NiceItemNamesCommentsInfo/5
        [HttpGet("{itemId}")]
        public async Task<ActionResult<NiceItemNamesCommentsInfo>> GetNiceItemNamesCommentsInfo(int itemId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceItemNamesCommentsInfo = await _context.NiceItemNamesCommentsInfos.SingleOrDefaultAsync(c => c.ItemId == itemId);

            if (niceItemNamesCommentsInfo == null)
            {
                return NotFound();
            }

            return niceItemNamesCommentsInfo;
        }
    }
}
