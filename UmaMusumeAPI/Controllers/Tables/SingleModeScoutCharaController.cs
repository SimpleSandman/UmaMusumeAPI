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
    public class SingleModeScoutCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeScoutCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeScoutChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeScoutChara>>> GetSingleModeScoutCharas()
        {
            return await _context.SingleModeScoutCharas.ToListAsync();
        }

        // GET: api/SingleModeScoutChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeScoutChara>> GetSingleModeScoutChara(int id)
        {
            var singleModeScoutChara = await _context.SingleModeScoutCharas.FindAsync(id);

            if (singleModeScoutChara == null)
            {
                return NotFound();
            }

            return singleModeScoutChara;
        }
    }
}
