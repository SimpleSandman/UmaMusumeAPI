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
    public class SingleModeRouteController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRouteController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRoute
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRoute>>> GetSingleModeRoutes()
        {
            return await _context.SingleModeRoutes.ToListAsync();
        }

        // GET: api/SingleModeRoute/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRoute>> GetSingleModeRoute(int id)
        {
            var singleModeRoute = await _context.SingleModeRoutes.FindAsync(id);

            if (singleModeRoute == null)
            {
                return NotFound();
            }

            return singleModeRoute;
        }
    }
}
