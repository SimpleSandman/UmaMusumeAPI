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
    public class SingleModeTeamNameController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTeamNameController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTeamName
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTeamName>>> GetSingleModeTeamNames()
        {
            return await _context.SingleModeTeamNames.ToListAsync();
        }

        // GET: api/SingleModeTeamName/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTeamName>> GetSingleModeTeamName(int id)
        {
            var singleModeTeamName = await _context.SingleModeTeamNames.FindAsync(id);

            if (singleModeTeamName == null)
            {
                return NotFound();
            }

            return singleModeTeamName;
        }
    }
}
