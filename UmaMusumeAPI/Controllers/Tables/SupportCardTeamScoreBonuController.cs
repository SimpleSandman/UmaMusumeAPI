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
    public class SupportCardTeamScoreBonuController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardTeamScoreBonuController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardTeamScoreBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardTeamScoreBonu>>> GetSupportCardTeamScoreBonus()
        {
            return await _context.SupportCardTeamScoreBonus.ToListAsync();
        }

        // GET: api/SupportCardTeamScoreBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardTeamScoreBonu>> GetSupportCardTeamScoreBonu(int id)
        {
            var supportCardTeamScoreBonu = await _context.SupportCardTeamScoreBonus.FindAsync(id);

            if (supportCardTeamScoreBonu == null)
            {
                return NotFound();
            }

            return supportCardTeamScoreBonu;
        }
    }
}
