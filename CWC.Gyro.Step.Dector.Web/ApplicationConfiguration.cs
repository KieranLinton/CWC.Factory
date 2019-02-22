using CWC.Domain.Objects.Logging;
using CWC.Domain.Objects.Person;
using CWC.Services.Logging;
using CWC.Services.Person;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SM.Mongo.DataBase.Repository.Person;

namespace CWC.Gyro.Step.Dector.Web
{
    public class ApplicationConfiguration
    {
        public void ApplyAppResourcesConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            // for next stage learning
            // services.Configure<ApplicationResources>(configuration.GetSection("ApplicationResources"));
        }
        public void ApplyAppSingletons(IServiceCollection services)
        {
            services.AddSingleton<ILoggingService, LoggingService>();
            services.AddSingleton<IPersonRepository, PersonRepository>();
            services.AddSingleton<IPersonService, PersonService>();
        }
        public void ApplyAppTransients(IServiceCollection services)
        {
            // for next stage learning
        }
    }
}
