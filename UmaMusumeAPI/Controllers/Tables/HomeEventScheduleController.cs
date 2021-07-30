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
    public class HomeEventScheduleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeEventScheduleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeEventSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeEventSchedule>>> GetHomeEventSchedules()
        {
            return await _context.HomeEventSchedules.ToListAsync();
        }

        // GET: api/HomeEventSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeEventSchedule>> GetHomeEventSchedule(int id)
        {
            var homeEventSchedule = await _context.HomeEventSchedules.FindAsync(id);

            if (homeEventSchedule == null)
            {
                return NotFound();
            }

            return homeEventSchedule;
        }
    }
}
