using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class UltimateRaceContentController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public UltimateRaceContentController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/UltimateRaceContent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UltimateRaceContent>>> GetUltimateRaceContent()
        {
            return await _context.UltimateRaceContents.ToListAsync();
        }

        // GET: api/UltimateRaceContent/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UltimateRaceContent>>> GetUltimateRaceContent(int id)
        {
            var ultimateRaceContent = await _context.UltimateRaceContents
                .Where(c => c.Id == id)
                .ToListAsync();

            if (ultimateRaceContent == null)
            {
                return NotFound();
            }

            return ultimateRaceContent;
        }
    }
}
