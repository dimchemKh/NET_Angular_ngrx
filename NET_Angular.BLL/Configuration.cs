using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using NET_Angular.BLL.Mapper;
using NET_Angular.BLL.Services;
using NET_Angular.BLL.Services.Interfaces;
using Repository = NET_Angular.DAL;

namespace NET_Angular.BLL
{
    public static class Configuration
    {
        public static void Add(IServiceCollection services/*, IConfiguration configuration*/)
        {
            Repository.Configuration.Add(services).GetAwaiter();
            Adddependecies(services);
            AddMappers(services);
        }
        private static void AddMappers(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MainMapper());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
        private static void Adddependecies(IServiceCollection services)
        {
            services.AddTransient<INoteService, NoteService>();
        }
    }
}
