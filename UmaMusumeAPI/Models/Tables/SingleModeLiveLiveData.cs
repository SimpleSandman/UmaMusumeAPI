using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeLiveLiveData
    {
        public int Id { get; set; }
        public int LiveType { get; set; }
        public int TurnNum { get; set; }
        public int GreatSuccessNum { get; set; }
        public int SongNum { get; set; }
        public int NormalMusicId { get; set; }
        public int SpecialMusicId { get; set; }
    }
}
