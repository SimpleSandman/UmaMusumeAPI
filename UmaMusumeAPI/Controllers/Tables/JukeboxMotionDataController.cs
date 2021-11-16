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
    public class JukeboxMotionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public JukeboxMotionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/JukeboxMotionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JukeboxMotionData>>> GetJukeboxMotionData()
        {
            return await _context.JukeboxMotionData.ToListAsync();
        }

        // GET: api/JukeboxMotionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JukeboxMotionData>> GetJukeboxMotionData(int id)
        {
            var jukeboxMotionData = await _context.JukeboxMotionData.FindAsync(id);

            if (jukeboxMotionData == null)
            {
                return NotFound();
            }

            return jukeboxMotionData;
        }
    }
}
