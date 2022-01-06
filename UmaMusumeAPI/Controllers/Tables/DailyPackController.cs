using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyPackController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyPackController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyPack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyPack>>> GetDailyPacks()
        {
            return await _context.DailyPacks.ToListAsync();
        }

        // GET: api/DailyPack/5
        [HttpGet("{shopDataId}")]
        public async Task<ActionResult<IEnumerable<DailyPack>>> GetDailyPack(int shopDataId)
        {
            var dailyPack = await _context.DailyPacks
                .Where(c => c.ShopDataId == shopDataId)
                .ToListAsync();

            if (dailyPack == null)
            {
                return NotFound();
            }

            return dailyPack;
        }
    }
}
