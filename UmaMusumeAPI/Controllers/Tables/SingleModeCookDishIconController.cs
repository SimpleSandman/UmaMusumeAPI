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
    public class SingleModeCookDishIconController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCookDishIconController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCookDishIcon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCookDishIcon>>> GetSingleModeCookDishIcons()
        {
            return await _context.SingleModeCookDishIcons.ToListAsync();
        }

        // GET: api/SingleModeCookDishIcon/5
        [HttpGet("{dishGroupId}")]
        public async Task<ActionResult<SingleModeCookDishIcon>> GetSingleModeCookDishIcon(int dishGroupId)
        {
            var singleModeCookDishIcon = await _context.SingleModeCookDishIcons.FindAsync(dishGroupId);

            if (singleModeCookDishIcon == null)
            {
                return NotFound();
            }

            return singleModeCookDishIcon;
        }
    }
}
