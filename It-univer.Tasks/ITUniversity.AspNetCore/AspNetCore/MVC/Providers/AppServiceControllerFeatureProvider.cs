using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ItUniversity.Application.Services;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ITUniversity.AspNetCore.MVC.Providers
{
    public class AppServiceControllerFeatureProvider : ControllerFeatureProvider
    {
        protected override bool IsController(TypeInfo typeInfo)
        {
            if (!typeof(IApplicationService).IsAssignableFrom(typeInfo.AsType()) ||
                !typeInfo.IsPublic || typeInfo.IsAbstract || typeInfo.IsGenericType)
            {
                return false;
            }

            return true;
        }
    }
}
