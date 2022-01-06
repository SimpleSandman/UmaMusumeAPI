using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;

namespace UmaMusumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : Controller 
        where T : class
    {
        private readonly UmaMusumeDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseController(UmaMusumeDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        // GET: api/[genericEntity]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> Get()
        {
            return await _dbSet.ToListAsync();
        }

        // GET: api/[genericEntity]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(int id)
        {
            T entity = await _dbSet.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }
    }
}
