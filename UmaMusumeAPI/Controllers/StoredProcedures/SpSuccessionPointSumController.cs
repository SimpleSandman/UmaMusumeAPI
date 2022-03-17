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

        // POST: api/SpSuccessionPointSum
        [HttpPost]
        public async Task<ActionResult<SpSuccessionPointSum>> GetSpSuccessionPointSum([FromBody] SpSuccessionPointSumDTO body)
        {
            if (body.Child == 0
                || body.Parent1 == 0 || body.Grandparent1A == 0 || body.Grandparent1B == 0
                || body.Parent2 == 0 || body.Grandparent2A == 0 || body.Grandparent2B == 0)
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

                    command.Parameters.Add(new MySqlParameter { ParameterName = "@child", Value = body.Child, MySqlDbType = MySqlDbType.Int32 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@parent1", Value = body.Parent1, MySqlDbType = MySqlDbType.Int32 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_1a", Value = body.Grandparent1A, MySqlDbType = MySqlDbType.Int32 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_1b", Value = body.Grandparent1B, MySqlDbType = MySqlDbType.Int32 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@parent2", Value = body.Parent2, MySqlDbType = MySqlDbType.Int32 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_2a", Value = body.Grandparent2A, MySqlDbType = MySqlDbType.Int32 });
                    command.Parameters.Add(new MySqlParameter { ParameterName = "@grand_parent_2b", Value = body.Grandparent2B, MySqlDbType = MySqlDbType.Int32 });

                    using (MySqlDataReader dr = await command.ExecuteReaderAsync())
                    {
                        await dr.ReadAsync();

                        return new SpSuccessionPointSum
                        {
                            Parent1Child = int.Parse(dr["parent1_child"].ToString()),
                            GrandparentAParent1 = int.Parse(dr["grandparentA_parent1"].ToString()),
                            GrandparentBParent1 = int.Parse(dr["grandparentB_parent1"].ToString()),
                            Parent2Child = int.Parse(dr["parent2_child"].ToString()),
                            GrandparentAParent2 = int.Parse(dr["grandparentA_parent2"].ToString()),
                            GrandparentBParent2 = int.Parse(dr["grandparentB_parent2"].ToString()),
                            Parent1Parent2 = int.Parse(dr["parent1_parent2"].ToString()),
                            PointSum = int.Parse(dr["point_sum"].ToString())
                        };
                    }
                }
            }
        }
    }
}
