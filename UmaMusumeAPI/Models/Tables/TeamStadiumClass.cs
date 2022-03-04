using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamStadiumClass
    {
        public int Id { get; set; }
        public int TeamStadiumId { get; set; }
        public int TeamClass { get; set; }
        public int UnitMaxNum { get; set; }
        public int ClassUpRange { get; set; }
        public int ClassDownRange { get; set; }
    }
}
