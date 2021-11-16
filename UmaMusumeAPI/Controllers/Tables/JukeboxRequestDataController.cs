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
    public class JukeboxRequestDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public JukeboxRequestDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/JukeboxRequestData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JukeboxRequestData>>> GetJukeboxRequestData()
        {
            return await _context.JukeboxRequestData.ToListAsync();
        }

        // GET: api/JukeboxRequestData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JukeboxRequestData>> GetJukeboxRequestData(int id)
        {
            var jukeboxRequestData = await _context.JukeboxRequestData.FindAsync(id);

            if (jukeboxRequestData == null)
            {
                return NotFound();
            }

            return jukeboxRequestData;
        }
    }
}
