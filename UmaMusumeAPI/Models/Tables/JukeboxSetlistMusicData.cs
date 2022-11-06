using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class JukeboxSetlistMusicData
    {
        public int Id { get; set; }
        public int SetlistId { get; set; }
        public int SetOrder { get; set; }
        public int MusicId { get; set; }
        public int PlayLength { get; set; }
    }
}
