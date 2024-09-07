using Serilog;
using Serilog.Events;

namespace WebApplication1;

public static class LoggerConfigurationExtension
{
    public static LoggerConfiguration Normal(this LoggerConfiguration logger)
    {
        logger.MinimumLevel.Debug()
            .MinimumLevel.Override("Default", LogEventLevel.Information)
            .MinimumLevel.Override("System", LogEventLevel.Information)
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
            .WriteTo.Console()
            .WriteTo.Async(p => p.File("Logs/logs-.txt", rollingInterval: RollingInterval.Day));

        return logger;
    }
}
