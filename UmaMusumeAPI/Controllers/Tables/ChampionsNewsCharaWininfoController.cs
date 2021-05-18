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
    public class ChampionsNewsCharaWininfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsCharaWininfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsCharaWininfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsCharaWininfo>>> GetChampionsNewsCharaWininfos()
        {
            return await _context.ChampionsNewsCharaWininfos.ToListAsync();
        }

        // GET: api/ChampionsNewsCharaWininfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsCharaWininfo>> GetChampionsNewsCharaWininfo(int id)
        {
            var championsNewsCharaWininfo = await _context.ChampionsNewsCharaWininfos.FindAsync(id);

            if (championsNewsCharaWininfo == null)
            {
                return NotFound();
            }

            return championsNewsCharaWininfo;
        }
    }
}
