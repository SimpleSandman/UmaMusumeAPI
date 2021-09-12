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
    public class SingleModeEventItemDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEventItemDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEventItemDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEventItemDetail>>> GetSingleModeEventItemDetails()
        {
            return await _context.SingleModeEventItemDetails.ToListAsync();
        }

        // GET: api/SingleModeEventItemDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeEventItemDetail>> GetSingleModeEventItemDetail(int id)
        {
            var singleModeEventItemDetail = await _context.SingleModeEventItemDetails.FindAsync(id);

            if (singleModeEventItemDetail == null)
            {
                return NotFound();
            }

            return singleModeEventItemDetail;
        }
    }
}
