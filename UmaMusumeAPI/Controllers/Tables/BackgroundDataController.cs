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
    public class BackgroundDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BackgroundDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BackgroundData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BackgroundData>>> GetBackgroundData()
        {
            return await _context.BackgroundData.ToListAsync();
        }

        // GET: api/BackgroundData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BackgroundData>> GetBackgroundData(int id)
        {
            var backgroundData = await _context.BackgroundData.FindAsync(id);

            if (backgroundData == null)
            {
                return NotFound();
            }

            return backgroundData;
        }
    }
}
