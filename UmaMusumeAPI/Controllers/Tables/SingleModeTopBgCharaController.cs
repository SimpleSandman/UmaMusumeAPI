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
    public class SingleModeTopBgCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTopBgCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTopBgChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTopBgChara>>> GetSingleModeTopBgCharas()
        {
            return await _context.SingleModeTopBgCharas.ToListAsync();
        }

        // GET: api/SingleModeTopBgChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTopBgChara>> GetSingleModeTopBgChara(int id)
        {
            var singleModeTopBg = await _context.SingleModeTopBgCharas.FindAsync(id);

            if (singleModeTopBg == null)
            {
                return NotFound();
            }

            return singleModeTopBg;
        }
    }
}
