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
    public class ChampionsNewsCharaDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsCharaDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsCharaDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsCharaDetail>>> GetChampionsNewsCharaDetails()
        {
            return await _context.ChampionsNewsCharaDetails.ToListAsync();
        }

        // GET: api/ChampionsNewsCharaDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsCharaDetail>> GetChampionsNewsCharaDetail(int id)
        {
            var championsNewsCharaDetail = await _context.ChampionsNewsCharaDetails.FindAsync(id);

            if (championsNewsCharaDetail == null)
            {
                return NotFound();
            }

            return championsNewsCharaDetail;
        }
    }
}
