using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class GachaStockDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaStockDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaStockDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaStockDetail>>> GetGachaStockDetail()
        {
            return await _context.GachaStockDetails.ToListAsync();
        }

        // GET: api/GachaStockDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaStockDetail>> GetGachaStockDetail(int id)
        {
            var gachaStockDetail = await _context.GachaStockDetails.FindAsync(id);

            if (gachaStockDetail == null)
            {
                return NotFound();
            }

            return gachaStockDetail;
        }
    }
}
