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
    public class ChampionsNewsTrainerWininfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsTrainerWininfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsTrainerWininfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsTrainerWininfo>>> GetChampionsNewsTrainerWininfos()
        {
            return await _context.ChampionsNewsTrainerWininfos.ToListAsync();
        }

        // GET: api/ChampionsNewsTrainerWininfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsTrainerWininfo>> GetChampionsNewsTrainerWininfo(int id)
        {
            var championsNewsTrainerWininfo = await _context.ChampionsNewsTrainerWininfos.FindAsync(id);

            if (championsNewsTrainerWininfo == null)
            {
                return NotFound();
            }

            return championsNewsTrainerWininfo;
        }
    }
}
