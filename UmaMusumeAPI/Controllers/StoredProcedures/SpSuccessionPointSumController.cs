using System.Data;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MySqlConnector;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.DTO;
using UmaMusumeAPI.Models.StoredProcedures;

namespace UmaMusumeAPI.Controllers.StoredProcedures
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpSuccessionPointSumController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SpSuccessionPointSumController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SpSuccessionPointSum
        [HttpPost]
        public async Task<ActionResult<SpSuccessionPointSum>> GetSpSuccessionPointSum([FromBody] SpSuccessionPointSumDTO body)
        {
            if (body.Child == 0L
                || body.Parent1 == 0L || body.Grandparent1A == 0L || body.Grandparent1B == 0L
                || body.Parent2 == 0L || body.Grandparent2A == 0L || body.Grandparent2B == 0L)
            {
                return NotFound();
            }

            using (MySqlConnection conn = new MySqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                await conn.OpenAsync();

                using (MySqlCommand command = conn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_succession_point_sum";

                    command.Parameters.Add(new MySqlParameter { ParameterName = "@child", Value = body.Child, MySqlDbType = MySqlDbType.Int64 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@parent1", Value = body.Parent1, MySqlDbType = MySqlDbType.Int64 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_1a", Value = body.Grandparent1A, MySqlDbType = MySqlDbType.Int64 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_1b", Value = body.Grandparent1B, MySqlDbType = MySqlDbType.Int64 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@parent2", Value = body.Parent2, MySqlDbType = MySqlDbType.Int64 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_2a", Value = body.Grandparent2A, MySqlDbType = MySqlDbType.Int64 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_2b", Value = body.Grandparent2B, MySqlDbType = MySqlDbType.Int64 });

                    using (MySqlDataReader dr = await command.ExecuteReaderAsync())
                    {
                        await dr.ReadAsync();

                        return new SpSuccessionPointSum
                        {
                            Parent1Child = (long)dr["parent1_child"],
                            GrandparentAParent1 = (long)dr["grandparentA_parent1"],
                            GrandparentBParent1 = (long)dr["grandparentB_parent1"],
                            Parent2Child = (long)dr["parent2_child"],
                            GrandparentAParent2 = (long)dr["grandparentA_parent2"],
                            GrandparentBParent2 = (long)dr["grandparentB_parent2"],
                            Parent1Parent2 = (long)dr["parent1_parent2"],
                            PointSum = (long)dr["point_sum"]
                        };
                    };
                }
            }
        }
    }
}
