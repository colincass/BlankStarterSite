namespace Web;

public class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                if (!string.IsNullOrEmpty(env))
                {
                    var bootstrapConfig = config.Build();
                    if (env.ToLower().Equals("development"))
                    {
                        config.AddJsonFile("appSettings.local.json", optional: true);
                    }
                }
            })
            .ConfigureCmsDefaults()
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
}
