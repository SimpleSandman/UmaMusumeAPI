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
    public class SingleModeCookGardenController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCookGardenController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCookGarden
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCookGarden>>> GetSingleModeCookGardens()
        {
            return await _context.SingleModeCookGardens.ToListAsync();
        }

        // GET: api/SingleModeCookGarden/5
        [HttpGet("{facilityId}")]
        public async Task<ActionResult<SingleModeCookGarden>> GetSingleModeCookGarden(int facilityId)
        {
            var singleModeCookGarden = await _context.SingleModeCookGardens.FindAsync(facilityId);

            if (singleModeCookGarden == null)
            {
                return NotFound();
            }

            return singleModeCookGarden;
        }
    }
}
