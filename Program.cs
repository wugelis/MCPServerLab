using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddConsole(options =>
{
    options.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services
   .AddMcpServer()
   .WithStdioServerTransport()
   .WithToolsFromAssembly();

await builder.Build().RunAsync();

[McpServerToolType]
public static class HelloWorldToolInstance
{
    [McpServerTool, Description("Hello World Tool")]
    public static string GetYourCityName(string city) =>
        $"Hello! Welcome to {city}!";
}
