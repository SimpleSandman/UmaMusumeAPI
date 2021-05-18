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
    public class SingleModeRecommendController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRecommendController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRecommend
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRecommend>>> GetSingleModeRecommends()
        {
            return await _context.SingleModeRecommends.ToListAsync();
        }

        // GET: api/SingleModeRecommend/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRecommend>> GetSingleModeRecommend(int id)
        {
            var singleModeRecommend = await _context.SingleModeRecommends.FindAsync(id);

            if (singleModeRecommend == null)
            {
                return NotFound();
            }

            return singleModeRecommend;
        }
    }
}
