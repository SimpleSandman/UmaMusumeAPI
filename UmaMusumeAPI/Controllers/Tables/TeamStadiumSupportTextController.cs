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
    public class TeamStadiumSupportTextController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumSupportTextController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumSupportText
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumSupportText>>> GetTeamStadiumSupportTexts()
        {
            return await _context.TeamStadiumSupportTexts.ToListAsync();
        }

        // GET: api/TeamStadiumSupportText/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumSupportText>> GetTeamStadiumSupportText(int id)
        {
            var teamStadiumSupportText = await _context.TeamStadiumSupportTexts.FindAsync(id);

            if (teamStadiumSupportText == null)
            {
                return NotFound();
            }

            return teamStadiumSupportText;
        }
    }
}
