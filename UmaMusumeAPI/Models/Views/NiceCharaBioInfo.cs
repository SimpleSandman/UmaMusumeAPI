using System;

namespace UmaMusumeAPI.Models.Views
{
    public class NiceCharaBioInfo
    {
        public int CharaId { get; set; }
        public long BirthYear { get; set; }
        public long BirthMonth { get; set; }
        public long BirthDay { get; set; }
        public long Sex { get; set; }
        public string ImageColorMain { get; set; }
        public string ImageColorSub { get; set; }
        public string UiColorMain { get; set; }
        public string UiColorSub { get; set; }
        public string UiTrainingColor1 { get; set; }
        public string UiTrainingColor2 { get; set; }
        public string UiBorderColor { get; set; }
        public string UiNumColor1 { get; set; }
        public string UiNumColor2 { get; set; }
        public string UiTurnColor { get; set; }
        public string UiWipeColor1 { get; set; }
        public string UiWipeColor2 { get; set; }
        public string UiWipeColor3 { get; set; }
        public string UiSpeechColor1 { get; set; }
        public string UiSpeechColor2 { get; set; }
        public string UiNameplateColor1 { get; set; }
        public string UiNameplateColor2 { get; set; }
        public long Height { get; set; }
        public long Bust { get; set; }
        public long Scale { get; set; }
        public long Skin { get; set; }
        public long Shape { get; set; }
        public long Socks { get; set; }
        public long PersonalDress { get; set; }
        public long TailModelId { get; set; }
        public long RaceRunningType { get; set; }
        public long EarRandomTimeMin { get; set; }
        public long EarRandomTimeMax { get; set; }
        public long TailRandomTimeMin { get; set; }
        public long TailRandomTimeMax { get; set; }
        public long StoryEarRandomTimeMin { get; set; }
        public long StoryEarRandomTimeMax { get; set; }
        public long StoryTailRandomTimeMin { get; set; }
        public long StoryTailRandomTimeMax { get; set; }
        public long AttachmentModelId { get; set; }
        public long MiniMayuShaderType { get; set; }
        public DateTime? StartDate { get; set; }
        public long CharaCategory { get; set; }
        public long? UraObjectives { get; set; }
    }
}
