
namespace Lanchonete;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args)
            .Build() 
            .Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) => // Adicionado "CreateHostBuilder"
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}