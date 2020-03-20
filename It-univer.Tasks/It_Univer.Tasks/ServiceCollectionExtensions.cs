using It_Univer.Tasks.Managers;
using It_Univer.Tasks.Stores;
using ITUniversity.AspNetCore.MVC;
using ITUniversity.Task.API;
using ITUniversity.Task.API.Services;
using ITUniversity.Task.API.Services.Imps;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace It_Univer.Tasks.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCoreServices(this IServiceCollection services)
        {
            services.AddSingleton<ITaskStore, TaskMemoryStore>();
            services.AddTransient<ITaskManager, TaskManager>();

            return services;
        }
        public static IServiceCollection AddTaskApplicationServices(this IServiceCollection services)
        {
            services.CreateControllersForAppServices(typeof(TaskApplicationModule).Assembly);
            services.AddTransient<ITaskAppService, TaskAppService>();

            return services;
        }
    }
}
