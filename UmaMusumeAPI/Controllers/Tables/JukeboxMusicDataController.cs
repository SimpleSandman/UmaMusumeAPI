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
    public class JukeboxMusicDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public JukeboxMusicDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/JukeboxMusicData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JukeboxMusicData>>> GetJukeboxMusicData()
        {
            return await _context.JukeboxMusicData.ToListAsync();
        }

        // GET: api/JukeboxMusicData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JukeboxMusicData>> GetJukeboxMusicData(int id)
        {
            var jukeboxMusicData = await _context.JukeboxMusicData.FindAsync(id);

            if (jukeboxMusicData == null)
            {
                return NotFound();
            }

            return jukeboxMusicData;
        }
    }
}
