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
    public class TransferEventRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TransferEventRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TransferEventReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransferEventReward>>> GetTransferEventRewards()
        {
            return await _context.TransferEventRewards.ToListAsync();
        }

        // GET: api/TransferEventReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransferEventReward>> GetTransferEventReward(int id)
        {
            var transferEventReward = await _context.TransferEventRewards.FindAsync(id);

            if (transferEventReward == null)
            {
                return NotFound();
            }

            return transferEventReward;
        }
    }
}
