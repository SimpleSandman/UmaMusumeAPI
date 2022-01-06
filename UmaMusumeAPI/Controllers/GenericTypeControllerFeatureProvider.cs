using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace UmaMusumeAPI.Controllers
{
    public class GenericTypeControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
    {
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            Assembly currentAssembly = typeof(GenericTypeControllerFeatureProvider).Assembly;
            IEnumerable<Type> candidates = currentAssembly.GetExportedTypes()
                .Where(x => x.GetCustomAttributes<GeneratedControllerAttribute>().Any());

            foreach (Type candidate in candidates)
            {
                feature.Controllers.Add(
                    typeof(BaseController<>).MakeGenericType(candidate).GetTypeInfo()
                );
            }
        }
    }
}
