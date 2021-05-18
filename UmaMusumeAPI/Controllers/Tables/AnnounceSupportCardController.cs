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
    public class AnnounceSupportCardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AnnounceSupportCardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AnnounceSupportCard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnounceSupportCard>>> GetAnnounceSupportCards()
        {
            return await _context.AnnounceSupportCards.ToListAsync();
        }

        // GET: api/AnnounceSupportCard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnounceSupportCard>> GetAnnounceSupportCard(int id)
        {
            var announceSupportCard = await _context.AnnounceSupportCards.FindAsync(id);

            if (announceSupportCard == null)
            {
                return NotFound();
            }

            return announceSupportCard;
        }
    }
}
