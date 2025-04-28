// See https://aka.ms/new-console-template for more information  
using System;
using ModelContextProtocol;
using ModelContextProtocol.Server;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = Host.CreateEmptyApplicationBuilder(settings: null);

builder.Services
   .AddMcpServer()
   .WithStdioServerTransport()
   .WithTools<HelloWorldToolInstance>();

await builder.Build().RunAsync();

[McpServerToolType]
public class HelloWorldToolInstance
{
    [McpServerTool, Description("Hello World Tool")]
    public string GetYourCityName(string city) =>
        $"Hello! Wellcome to {city}!";
}
