using System;
using System.Runtime.CompilerServices;

namespace UmaMusumeAPI.Controllers
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class GeneratedControllerAttribute : Attribute
    {
        public string Route { get; set; }

        public GeneratedControllerAttribute([CallerMemberName] string propertyName = null)
        {
            Route = propertyName;
        }
    }
}
