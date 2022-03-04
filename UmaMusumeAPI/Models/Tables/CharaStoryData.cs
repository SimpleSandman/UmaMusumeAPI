using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharaStoryData
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int EpisodeIndex { get; set; }
        public int StoryId { get; set; }
        public int LockType1 { get; set; }
        public int LockValue11 { get; set; }
        public int LockValue12 { get; set; }
        public int AddRewardCategory1 { get; set; }
        public int AddRewardId1 { get; set; }
        public int AddRewardNum1 { get; set; }
        public int ExpType { get; set; }
    }
}
