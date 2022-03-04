using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceEnvDefine
    {
        public int Id { get; set; }
        public int RaceTrackId { get; set; }
        public int Season { get; set; }
        public int Weather { get; set; }
        public int Timezone { get; set; }
        public int Resource { get; set; }
    }
}
