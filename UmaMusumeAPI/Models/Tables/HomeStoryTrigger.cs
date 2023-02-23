using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HomeStoryTrigger
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int HomeEventType { get; set; }
        public int Num { get; set; }
        public int StoryId { get; set; }
        public int CharaId1 { get; set; }
        public int CharaId2 { get; set; }
        public int CharaId3 { get; set; }
        public int ConditionType { get; set; }
        public int GalleryCharaId { get; set; }
        public int DispOrder { get; set; }
        public int StartDate { get; set; }
        public int AvailableGalleryKey { get; set; }
    }
}
