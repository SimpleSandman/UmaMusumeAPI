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
    public class JukeboxCharaTagDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public JukeboxCharaTagDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/JukeboxCharaTagData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JukeboxCharaTagData>>> GetJukeboxCharaTagData()
        {
            return await _context.JukeboxCharaTagData.ToListAsync();
        }

        // GET: api/JukeboxCharaTagData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JukeboxCharaTagData>> GetJukeboxCharaTagData(int id)
        {
            var jukeboxCharaTagData = await _context.JukeboxCharaTagData.FindAsync(id);

            if (jukeboxCharaTagData == null)
            {
                return NotFound();
            }

            return jukeboxCharaTagData;
        }
    }
}
