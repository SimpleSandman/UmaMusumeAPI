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
    public class SingleModeAoTrainingPlateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAoTrainingPlateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAoTrainingPlate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAoTrainingPlate>>> GetSingleModeAoTrainingPlates()
        {
            return await _context.SingleModeAoTrainingPlates.ToListAsync();
        }

        // GET: api/SingleModeAoTrainingPlate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAoTrainingPlate>> GetSingleModeAoTrainingPlate(int id)
        {
            var singleModeAoTrainingPlate = await _context.SingleModeAoTrainingPlates.FindAsync(id);

            if (singleModeAoTrainingPlate == null)
            {
                return NotFound();
            }

            return singleModeAoTrainingPlate;
        }
    }
}
