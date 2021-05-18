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
    public class SingleModeTagCardPoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTagCardPoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTagCardPo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTagCardPo>>> GetSingleModeTagCardPos()
        {
            return await _context.SingleModeTagCardPos.ToListAsync();
        }

        // GET: api/SingleModeTagCardPo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTagCardPo>> GetSingleModeTagCardPo(int id)
        {
            var singleModeTagCardPo = await _context.SingleModeTagCardPos.FindAsync(id);

            if (singleModeTagCardPo == null)
            {
                return NotFound();
            }

            return singleModeTagCardPo;
        }
    }
}
