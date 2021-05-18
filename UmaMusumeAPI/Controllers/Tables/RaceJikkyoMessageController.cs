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
    public class RaceJikkyoMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoMessage>>> GetRaceJikkyoMessages()
        {
            return await _context.RaceJikkyoMessages.ToListAsync();
        }

        // GET: api/RaceJikkyoMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoMessage>> GetRaceJikkyoMessage(int id)
        {
            var raceJikkyoMessage = await _context.RaceJikkyoMessages.FindAsync(id);

            if (raceJikkyoMessage == null)
            {
                return NotFound();
            }

            return raceJikkyoMessage;
        }
    }
}
