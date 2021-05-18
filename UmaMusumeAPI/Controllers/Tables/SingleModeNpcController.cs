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
    public class SingleModeNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeNpc>>> GetSingleModeNpcs()
        {
            return await _context.SingleModeNpcs.ToListAsync();
        }

        // GET: api/SingleModeNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeNpc>> GetSingleModeNpc(int id)
        {
            var singleModeNpc = await _context.SingleModeNpcs.FindAsync(id);

            if (singleModeNpc == null)
            {
                return NotFound();
            }

            return singleModeNpc;
        }
    }
}
