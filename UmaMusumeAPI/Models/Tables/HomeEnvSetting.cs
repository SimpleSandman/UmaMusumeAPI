using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HomeEnvSetting
    {
        public int Id { get; set; }
        public int HomeSetId { get; set; }
        public int HomeEventType { get; set; }
        public int ResourceEventCheck { get; set; }
        public int Season { get; set; }
        public int Weather { get; set; }
        public int Timezone { get; set; }
        public int Resource { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
    }
}
