namespace UmaMusumeAPI.Models.Tables
{
    public class MiniMotionSet
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string BodyMotion { get; set; }
        public int BodyMotionType { get; set; }
        public int BodyMotionPlayType { get; set; }
        public int BodyMotionSceneType { get; set; }
        public string SceneSubFolder { get; set; }
        public int CharaTypeTarget { get; set; }
        public int AddLayerIndex { get; set; }
        public int IsMirror { get; set; }
        public string FacialMotion { get; set; }
        public string CharaFaceType { get; set; }
        public int TransitionTime { get; set; }
        public string EarMotion { get; set; }
        public int IsEnableRandomeEar { get; set; }
        public string TailMotion { get; set; }
        public int TailMotionType { get; set; }
        public int IsEnableRandomeTail { get; set; }
        public int PropId { get; set; }
        public string PropMotion { get; set; }
        public int PropMotionSceneType { get; set; }
        public int PropAttachNodeNameType { get; set; }
        public int IsPropRequireMotionEnd { get; set; }
        public int PropId2 { get; set; }
        public string PropMotion2 { get; set; }
        public int PropMotionSceneType2 { get; set; }
        public int PropAttachNodeNameType2 { get; set; }
        public int UseTailInBodyMotion { get; set; }
    }
}
