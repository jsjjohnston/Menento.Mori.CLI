
using Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("config.json")
                                                                 .Build();

        using IHost host = Host.CreateDefaultBuilder(args)
                               .ConfigureServices((_, services) =>
                                    services.AddApplication(configuration))
                               .Build();
    }
}
