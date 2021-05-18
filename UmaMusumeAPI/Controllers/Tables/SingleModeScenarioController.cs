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
    public class SingleModeScenarioController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeScenarioController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeScenario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeScenario>>> GetSingleModeScenarios()
        {
            return await _context.SingleModeScenarios.ToListAsync();
        }

        // GET: api/SingleModeScenario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeScenario>> GetSingleModeScenario(int id)
        {
            var singleModeScenario = await _context.SingleModeScenarios.FindAsync(id);

            if (singleModeScenario == null)
            {
                return NotFound();
            }

            return singleModeScenario;
        }
    }
}
