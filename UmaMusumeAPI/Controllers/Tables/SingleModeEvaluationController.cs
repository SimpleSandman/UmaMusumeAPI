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
    public class SingleModeEvaluationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEvaluationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEvaluation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEvaluation>>> GetSingleModeEvaluations()
        {
            return await _context.SingleModeEvaluations.ToListAsync();
        }

        // GET: api/SingleModeEvaluation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeEvaluation>> GetSingleModeEvaluation(int id)
        {
            var singleModeEvaluation = await _context.SingleModeEvaluations.FindAsync(id);

            if (singleModeEvaluation == null)
            {
                return NotFound();
            }

            return singleModeEvaluation;
        }
    }
}
