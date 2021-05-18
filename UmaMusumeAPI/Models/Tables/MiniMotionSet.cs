using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class MiniMotionSet
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string BodyMotion { get; set; }
        public long BodyMotionType { get; set; }
        public long BodyMotionPlayType { get; set; }
        public long BodyMotionSceneType { get; set; }
        public string SceneSubFolder { get; set; }
        public long CharaTypeTarget { get; set; }
        public long AddLayerIndex { get; set; }
        public long IsMirror { get; set; }
        public string FacialMotion { get; set; }
        public string CharaFaceType { get; set; }
        public long TransitionTime { get; set; }
        public string EarMotion { get; set; }
        public long IsEnableRandomeEar { get; set; }
        public string TailMotion { get; set; }
        public long TailMotionType { get; set; }
        public long IsEnableRandomeTail { get; set; }
        public long PropId { get; set; }
        public string PropMotion { get; set; }
        public long PropMotionSceneType { get; set; }
        public long PropAttachNodeNameType { get; set; }
        public long IsPropRequireMotionEnd { get; set; }
    }
}
