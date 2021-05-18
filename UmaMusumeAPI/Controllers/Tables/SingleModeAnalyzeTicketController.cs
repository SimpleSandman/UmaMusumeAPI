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
    public class SingleModeAnalyzeTicketController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAnalyzeTicketController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAnalyzeTicket
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAnalyzeTicket>>> GetSingleModeAnalyzeTickets()
        {
            return await _context.SingleModeAnalyzeTickets.ToListAsync();
        }

        // GET: api/SingleModeAnalyzeTicket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAnalyzeTicket>> GetSingleModeAnalyzeTicket(int id)
        {
            var singleModeAnalyzeTicket = await _context.SingleModeAnalyzeTickets.FindAsync(id);

            if (singleModeAnalyzeTicket == null)
            {
                return NotFound();
            }

            return singleModeAnalyzeTicket;
        }
    }
}
