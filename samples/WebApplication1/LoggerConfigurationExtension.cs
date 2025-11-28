using Serilog;

namespace WebApplication1;

public static class LoggerConfigurationExtension
{
    public static LoggerConfiguration Normal(this LoggerConfiguration logger)
    {
        logger.MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.Async(p => p.File("Logs/logs-.txt", rollingInterval: RollingInterval.Day));

        return logger;
    }
}
