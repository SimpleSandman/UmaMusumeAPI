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
    public class SingleModeRaceGroupController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRaceGroupController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRaceGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRaceGroup>>> GetSingleModeRaceGroups()
        {
            return await _context.SingleModeRaceGroups.ToListAsync();
        }

        // GET: api/SingleModeRaceGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRaceGroup>> GetSingleModeRaceGroup(int id)
        {
            var singleModeRaceGroup = await _context.SingleModeRaceGroups.FindAsync(id);

            if (singleModeRaceGroup == null)
            {
                return NotFound();
            }

            return singleModeRaceGroup;
        }
    }
}
