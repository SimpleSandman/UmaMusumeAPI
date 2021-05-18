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
    public class GachaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaData>>> GetGachaData()
        {
            return await _context.GachaData.ToListAsync();
        }

        // GET: api/GachaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaData>> GetGachaData(int id)
        {
            var gachaData = await _context.GachaData.FindAsync(id);

            if (gachaData == null)
            {
                return NotFound();
            }

            return gachaData;
        }
    }
}
