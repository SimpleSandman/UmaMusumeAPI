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
    public class SingleModeCharaGradeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCharaGradeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCharaGrade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCharaGrade>>> GetSingleModeCharaGrades()
        {
            return await _context.SingleModeCharaGrades.ToListAsync();
        }

        // GET: api/SingleModeCharaGrade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeCharaGrade>> GetSingleModeCharaGrade(int id)
        {
            var singleModeCharaGrade = await _context.SingleModeCharaGrades.FindAsync(id);

            if (singleModeCharaGrade == null)
            {
                return NotFound();
            }

            return singleModeCharaGrade;
        }
    }
}
