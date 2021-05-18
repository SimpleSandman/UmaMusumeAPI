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
    public class SeasonDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SeasonDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SeasonData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeasonData>>> GetSeasonData()
        {
            return await _context.SeasonData.ToListAsync();
        }

        // GET: api/SeasonData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SeasonData>> GetSeasonData(int id)
        {
            var seasonData = await _context.SeasonData.FindAsync(id);

            if (seasonData == null)
            {
                return NotFound();
            }

            return seasonData;
        }
    }
}
