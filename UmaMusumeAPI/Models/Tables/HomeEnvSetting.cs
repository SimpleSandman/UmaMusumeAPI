namespace UmaMusumeAPI.Models.Tables
{
    public class HomeEnvSetting
    {
        public int Id { get; set; }
        public long HomeSetId { get; set; }
        public long HomeEventType { get; set; }
        public long ResourceEventCheck { get; set; }
        public long Season { get; set; }
        public long Weather { get; set; }
        public long Timezone { get; set; }
        public long Resource { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
    }
}
