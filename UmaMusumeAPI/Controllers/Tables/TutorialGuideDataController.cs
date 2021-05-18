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
    public class TutorialGuideDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TutorialGuideDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TutorialGuideData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialGuideData>>> GetTutorialGuideData()
        {
            return await _context.TutorialGuideData.ToListAsync();
        }

        // GET: api/TutorialGuideData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialGuideData>> GetTutorialGuideData(int id)
        {
            var tutorialGuideData = await _context.TutorialGuideData.FindAsync(id);

            if (tutorialGuideData == null)
            {
                return NotFound();
            }

            return tutorialGuideData;
        }
    }
}
