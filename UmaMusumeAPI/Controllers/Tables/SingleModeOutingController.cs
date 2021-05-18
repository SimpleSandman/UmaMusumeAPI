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
    public class SingleModeOutingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeOutingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeOuting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeOuting>>> GetSingleModeOutings()
        {
            return await _context.SingleModeOutings.ToListAsync();
        }

        // GET: api/SingleModeOuting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeOuting>> GetSingleModeOuting(int id)
        {
            var singleModeOuting = await _context.SingleModeOutings.FindAsync(id);

            if (singleModeOuting == null)
            {
                return NotFound();
            }

            return singleModeOuting;
        }
    }
}
