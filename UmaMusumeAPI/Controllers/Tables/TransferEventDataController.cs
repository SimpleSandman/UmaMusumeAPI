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
    public class TransferEventDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TransferEventDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TransferEventData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransferEventData>>> GetTransferEventData()
        {
            return await _context.TransferEventData.ToListAsync();
        }

        // GET: api/TransferEventData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransferEventData>> GetTransferEventData(int id)
        {
            var transferEventData = await _context.TransferEventData.FindAsync(id);

            if (transferEventData == null)
            {
                return NotFound();
            }

            return transferEventData;
        }
    }
}
