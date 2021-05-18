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
    public class ChampionsRoundDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRoundDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRoundDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRoundDetail>>> GetChampionsRoundDetails()
        {
            return await _context.ChampionsRoundDetails.ToListAsync();
        }

        // GET: api/ChampionsRoundDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsRoundDetail>> GetChampionsRoundDetail(int id)
        {
            var championsRoundDetail = await _context.ChampionsRoundDetails.FindAsync(id);

            if (championsRoundDetail == null)
            {
                return NotFound();
            }

            return championsRoundDetail;
        }
    }
}
