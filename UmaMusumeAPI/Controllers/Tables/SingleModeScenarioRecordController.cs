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
    public class SingleModeScenarioRecordController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeScenarioRecordController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeScenarioRecord
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeScenarioRecord>>> GetSingleModeScenarioRecords()
        {
            return await _context.SingleModeScenarioRecords.ToListAsync();
        }

        // GET: api/SingleModeScenarioRecord/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeScenarioRecord>> GetSingleModeScenarioRecord(int id)
        {
            var singleModeScenarioRecord = await _context.SingleModeScenarioRecords.FindAsync(id);

            if (singleModeScenarioRecord == null)
            {
                return NotFound();
            }

            return singleModeScenarioRecord;
        }
    }
}
