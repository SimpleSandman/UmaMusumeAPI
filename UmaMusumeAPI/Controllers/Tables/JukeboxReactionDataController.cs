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
    public class JukeboxReactionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public JukeboxReactionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/JukeboxReactionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JukeboxReactionData>>> GetJukeboxReactionData()
        {
            return await _context.JukeboxReactionData.ToListAsync();
        }

        // GET: api/JukeboxReactionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JukeboxReactionData>> GetJukeboxReactionData(int id)
        {
            var jukeboxReactionData = await _context.JukeboxReactionData.FindAsync(id);

            if (jukeboxReactionData == null)
            {
                return NotFound();
            }

            return jukeboxReactionData;
        }
    }
}
