using Microsoft.Extensions.DependencyInjection;
using NET_Angular.DAL.Repository;
using System.Threading.Tasks;

namespace NET_Angular.DAL
{
    public static class Configuration
    {
        public static async Task Add(IServiceCollection services/*, string connectionString*/)
        {
            InitDatabase(services);
            //await Initialize(services);
            AddDependencies(services);
        }
        private static void InitDatabase(IServiceCollection services)
        {
            services.AddSingleton(typeof(MockedDatabase));
        }
        //private static async Task Initialize(IServiceCollection services)
        //{
        //    ServiceProvider serviceProvider = services.BuildServiceProvider();

        //    var mockedDatabase = serviceProvider.GetRequiredService<MockedDatabase>();

        //    await Initializer.InitDefaultNotes( mockedDatabase);
        //}
        private static void AddDependencies(IServiceCollection services)
        {
            services.AddTransient(typeof(NoteRepository));
        }
    }
}
