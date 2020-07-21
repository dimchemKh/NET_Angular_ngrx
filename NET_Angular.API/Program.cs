using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace NET_Angular_Aionys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task.Run(() =>
            //{
            //    var assembly = Assembly.LoadFrom("NET_Angular.WEB");

            //    Type t = assembly.GetType("NET_Angular.WEB.Program");

            //    var method = t.GetMethod("Main");

            //    var obj = Activator.CreateInstance(t);
            //    System.String[] args = new string[] { "%LAUNCHER_ARGS%" };
            //    method.Invoke(obj, args);
            //    //t.GetMethod("Main", new Type[], { new string[] { "%LAUNCHER_ARGS%" } });
            //});
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
