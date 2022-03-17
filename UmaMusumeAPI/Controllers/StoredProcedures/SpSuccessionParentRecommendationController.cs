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
    public class SpSuccessionParentRecommendationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SpSuccessionParentRecommendationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SpSuccessionParentRecommendation/1008
        [HttpGet("{child}")]
        public async Task<ActionResult<IEnumerable<SpSuccessionParentRecommendation>>> GetSpSuccessionParentRecommendation(int child)
        {
            if (child == 0)
            {
                return NotFound();
            }

            using (MySqlConnection conn = new MySqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                await conn.OpenAsync();

                using (MySqlCommand command = conn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_succession_parent_recommendation";

                    command.Parameters.Add(new MySqlParameter { ParameterName = "@child", Value = child, MySqlDbType = MySqlDbType.Int32 });

                    using (MySqlDataReader dr = await command.ExecuteReaderAsync())
                    {
                        List<SpSuccessionParentRecommendation> parentRecommendations = new List<SpSuccessionParentRecommendation>();
                        
                        while (await dr.ReadAsync())
                        {
                            parentRecommendations.Add(new SpSuccessionParentRecommendation
                            {
                                ParentRecommendationId = int.Parse(dr["parent_recommendation_id"].ToString()),
                                ParentCompatibility = int.Parse(dr["parent_compatibility"].ToString())
                            });
                        }

                        return parentRecommendations;
                    }
                }
            }
        }
    }
}
