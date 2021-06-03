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
    public class BasicItemExchangeTopInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicItemExchangeTopInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicItemExchangeTopInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicItemExchangeTopInfo>>> GetBasicItemExchangeTopInfos()
        {
            return await _context.BasicItemExchangeTopInfos.ToListAsync();
        }

        // GET: api/BasicItemExchangeTopInfo/5
        [HttpGet("{itemExchangeTopId}")]
        public async Task<ActionResult<BasicItemExchangeTopInfo>> GetBasicItemExchangeTopInfo(int itemExchangeTopId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicItemExchangeTopInfo = await _context.BasicItemExchangeTopInfos.SingleOrDefaultAsync(c => c.ItemExchangeTopId == itemExchangeTopId);

            if (basicItemExchangeTopInfo == null)
            {
                return NotFound();
            }

            return basicItemExchangeTopInfo;
        }
    }
}
