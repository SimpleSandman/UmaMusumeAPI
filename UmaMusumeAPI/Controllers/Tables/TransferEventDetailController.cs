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
    public class TransferEventDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TransferEventDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TransferEventDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransferEventDetail>>> GetTransferEventDetails()
        {
            return await _context.TransferEventDetails.ToListAsync();
        }

        // GET: api/TransferEventDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransferEventDetail>> GetTransferEventDetail(int id)
        {
            var transferEventDetail = await _context.TransferEventDetails.FindAsync(id);

            if (transferEventDetail == null)
            {
                return NotFound();
            }

            return transferEventDetail;
        }
    }
}
