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
    public class BackgroundOffsetDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BackgroundOffsetDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BackgroundOffsetData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BackgroundOffsetData>>> GetBackgroundOffsetData()
        {
            return await _context.BackgroundOffsetData.ToListAsync();
        }

        // GET: api/BackgroundOffsetData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BackgroundOffsetData>> GetBackgroundOffsetData(int id)
        {
            var backgroundOffsetData = await _context.BackgroundOffsetData.FindAsync(id);

            if (backgroundOffsetData == null)
            {
                return NotFound();
            }

            return backgroundOffsetData;
        }
    }
}
