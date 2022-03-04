using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class AudioStoryEffect
    {
        public int Id { get; set; }
        public string EffectName { get; set; }
        public string CueName { get; set; }
        public string CueSheet { get; set; }
        public int LoopSet { get; set; }
    }
}
