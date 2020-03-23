using It_Univer.Tasks.Managers;
using It_Univer.Tasks.Stores;
using It_Univerity.Tasks.NHibernate;
using ITUniversity.AspNetCore.MVC;
using ITUniversity.Task.API;
using ITUniversity.Task.API.Services;
using ITUniversity.Task.API.Services.Imps;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using It_Univer.Tasks.Repositories;
using It_University.Tasks.NHibernate.Repositories;

namespace It_Univer.Tasks.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCoreServices(this IServiceCollection services)
        {
 //           services.AddSingleton<ITaskStore, TaskMemoryStore>();
            services.AddScoped<ITaskStore, TaskDbStore>();
            services.AddTransient<ITaskManager, TaskManager>();

            return services;
        }
        public static IServiceCollection AddTaskApplicationServices(this IServiceCollection services)
        {
            services.CreateControllersForAppServices(typeof(TaskApplicationModule).Assembly);
            services.AddTransient<ITaskAppService, TaskAppService>();

            return services;
        }
        public static IServiceCollection AddTaskNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(TaskNHibernateModule).Assembly.ExportedTypes);
            var mappings = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new Configuration();
            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MsSql2012Dialect>();
                c.ConnectionString = connectionString;
                //c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                //c.SchemaAction = SchemaAutoAction.Validate;
                //c.LogFormattedSql = true;
                //c.LogSqlInConsole = true;
            });
            configuration.AddMapping(mappings);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());

            //services.AddScoped<IMapperSession, NHibernateMapperSession>();

            services.AddScoped<ITaskRepository, TaskRepository>();

            return services;
        }
    }
}
