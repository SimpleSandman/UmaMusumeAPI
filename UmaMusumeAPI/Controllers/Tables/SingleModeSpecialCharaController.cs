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
    public class SingleModeSpecialCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeSpecialCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeSpecialChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeSpecialChara>>> GetSingleModeSpecialCharas()
        {
            return await _context.SingleModeSpecialCharas.ToListAsync();
        }

        // GET: api/SingleModeSpecialChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeSpecialChara>> GetSingleModeSpecialChara(int id)
        {
            var singleModeSpecialChara = await _context.SingleModeSpecialCharas.FindAsync(id);

            if (singleModeSpecialChara == null)
            {
                return NotFound();
            }

            return singleModeSpecialChara;
        }
    }
}
