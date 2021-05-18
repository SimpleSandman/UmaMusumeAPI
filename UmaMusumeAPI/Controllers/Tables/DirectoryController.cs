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
    public class DirectoryController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DirectoryController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/Directory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Directory>>> GetDirectories()
        {
            return await _context.Directories.ToListAsync();
        }

        // GET: api/Directory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Directory>> GetDirectory(int id)
        {
            var directory = await _context.Directories.FindAsync(id);

            if (directory == null)
            {
                return NotFound();
            }

            return directory;
        }
    }
}
