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
    public class SingleModeUniqueCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeUniqueCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeUniqueChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeUniqueChara>>> GetSingleModeUniqueCharas()
        {
            return await _context.SingleModeUniqueCharas.ToListAsync();
        }

        // GET: api/SingleModeUniqueChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeUniqueChara>> GetSingleModeUniqueChara(int id)
        {
            var singleModeUniqueChara = await _context.SingleModeUniqueCharas.FindAsync(id);

            if (singleModeUniqueChara == null)
            {
                return NotFound();
            }

            return singleModeUniqueChara;
        }
    }
}
