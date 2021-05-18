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
    public class MainStoryPartController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryPartController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryPart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryPart>>> GetMainStoryParts()
        {
            return await _context.MainStoryParts.ToListAsync();
        }

        // GET: api/MainStoryPart/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryPart>> GetMainStoryPart(int id)
        {
            var mainStoryPart = await _context.MainStoryParts.FindAsync(id);

            if (mainStoryPart == null)
            {
                return NotFound();
            }

            return mainStoryPart;
        }
    }
}
