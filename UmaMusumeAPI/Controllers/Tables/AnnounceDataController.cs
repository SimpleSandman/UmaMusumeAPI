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
    public class AnnounceDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AnnounceDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AnnounceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnounceData>>> GetAnnounceData()
        {
            return await _context.AnnounceData.ToListAsync();
        }

        // GET: api/AnnounceData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnounceData>> GetAnnounceData(int id)
        {
            var announceData = await _context.AnnounceData.FindAsync(id);

            if (announceData == null)
            {
                return NotFound();
            }

            return announceData;
        }
    }
}
