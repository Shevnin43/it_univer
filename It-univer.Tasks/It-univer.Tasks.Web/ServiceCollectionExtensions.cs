
using ItUniver.Task.Manager;
using ItUniver.Task.Stores;

using Microsoft.Extensions.DependencyInjection;

namespace It_univer.Tasks.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCoreServices(this IServiceCollection services)
        {
            services.AddSingleton<ITaskStore, TaskMemoryStore>();
            services.AddTransient<ITaskManager, TaskManager>();

            return services;
        }
    }
}