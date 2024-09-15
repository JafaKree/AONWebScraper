using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace AONWebScraper
{
    public class CustomLoggerConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Information;
        public string LogDirectory { get; set; } = "Logs";
    }

    public class CustomLogger : ILogger
    {
        private readonly string _name;
        private readonly CustomLoggerConfiguration _config;
        private readonly string _logFilePath;

        public CustomLogger(string name, CustomLoggerConfiguration config)
        {
            _name = name;
            _config = config;
            Directory.CreateDirectory(_config.LogDirectory);
            _logFilePath = Path.Combine(_config.LogDirectory, $"" +
                $"{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}" +
                $"-{DateTime.Now.Hour}_{DateTime.Now.Minute}_{DateTime.Now.Second}_{DateTime.Now.Millisecond}.log");
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public bool IsEnabled(LogLevel logLevel) => logLevel >= _config.LogLevel;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            var logRecord = $"{DateTime.Now}: {logLevel.ToString()} - {formatter(state, exception)}";
            File.AppendAllText(_logFilePath, logRecord + Environment.NewLine);
        }
    }
}
