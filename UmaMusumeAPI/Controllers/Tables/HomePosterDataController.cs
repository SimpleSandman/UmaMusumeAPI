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
    public class HomePosterDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomePosterDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomePosterData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomePosterData>>> GetHomePosterData()
        {
            return await _context.HomePosterData.ToListAsync();
        }

        // GET: api/HomePosterData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomePosterData>> GetHomePosterData(int id)
        {
            var homePosterData = await _context.HomePosterData.FindAsync(id);

            if (homePosterData == null)
            {
                return NotFound();
            }

            return homePosterData;
        }
    }
}
