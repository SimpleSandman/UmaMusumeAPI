using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MySqlConnector;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.StoredProcedures;

namespace UmaMusumeAPI.Controllers.StoredProcedures
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpSuccessionGrandparentRecommendationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SpSuccessionGrandparentRecommendationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SpSuccessionGrandparentRecommendation/1008/1011
        [HttpGet("{child}/{parent}")]
        public async Task<ActionResult<IEnumerable<SpSuccessionGrandparentRecommendation>>> GetSpSuccessionGrandparentRecommendation(long child, long parent)
        {
            if (child == 0L || parent == 0L)
            {
                return NotFound();
            }

            using (MySqlConnection conn = new MySqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                await conn.OpenAsync();

                using (MySqlCommand command = conn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_succession_grandparent_recommendation";

                    command.Parameters.Add(new MySqlParameter { ParameterName = "@child", Value = child, MySqlDbType = MySqlDbType.Int64 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@parent", Value = parent, MySqlDbType = MySqlDbType.Int64 });

                    using (MySqlDataReader dr = await command.ExecuteReaderAsync())
                    {
                        List<SpSuccessionGrandparentRecommendation> grandparentRecommendations = new List<SpSuccessionGrandparentRecommendation>();

                        while (await dr.ReadAsync())
                        {
                            grandparentRecommendations.Add(new SpSuccessionGrandparentRecommendation 
                            {
                                GrandparentRecommendationId = (int)dr["grandparent_recommendation_id"],
                                GrandparentCompatibility = (int)dr["grandparent_compatibility"]
                            });
                        }

                        return grandparentRecommendations;
                    }
                }
            }
        }
    }
}
