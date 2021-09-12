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
    public class SingleModeAoharuResultCuttController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAoharuResultCuttController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAoharuResultCutt
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAoharuResultCutt>>> GetSingleModeAoharuResultCutts()
        {
            return await _context.SingleModeAoharuResultCutts.ToListAsync();
        }

        // GET: api/SingleModeAoharuResultCutt/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAoharuResultCutt>> GetSingleModeAoharuResultCutt(int id)
        {
            var singleModeAoharuResultCutt = await _context.SingleModeAoharuResultCutts.FindAsync(id);

            if (singleModeAoharuResultCutt == null)
            {
                return NotFound();
            }

            return singleModeAoharuResultCutt;
        }
    }
}
