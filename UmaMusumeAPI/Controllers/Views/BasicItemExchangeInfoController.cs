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
    public class BasicItemExchangeInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicItemExchangeInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicItemExchangeInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicItemExchangeInfo>>> GetBasicItemExchangeInfos()
        {
            return await _context.BasicItemExchangeInfos.ToListAsync();
        }

        // GET: api/BasicItemExchangeInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasicItemExchangeInfo>> GetBasicItemExchangeInfo(int id)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicItemExchangeInfo = await _context.BasicItemExchangeInfos.SingleOrDefaultAsync(c => c.ItemExchangeId == id);

            if (basicItemExchangeInfo == null)
            {
                return NotFound();
            }

            return basicItemExchangeInfo;
        }
    }
}
