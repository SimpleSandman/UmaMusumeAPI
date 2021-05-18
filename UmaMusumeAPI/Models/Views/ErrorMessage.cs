using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class ErrorMessage
    {
        public long ErrorId { get; set; }
        public int ErrorIndex { get; set; }
        public string ErrorText { get; set; }
    }
}
