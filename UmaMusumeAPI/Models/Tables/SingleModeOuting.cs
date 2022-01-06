using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeOuting
    {
        public int Id { get; set; }
        public long CommandGroupId { get; set; }
        public long Condition { get; set; }
        public long IsPlayCutt { get; set; }
    }
}
