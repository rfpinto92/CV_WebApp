using Api.Gateway;
using Api.Gateway.Interfaces;
using Api.Services;
using Api.Services.Interface;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddSingleton<IMongoGateway, MongoGateway>();
        services.AddTransient<IMongoDB_Service, MongoDB_Service>();
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        
    })
    .Build();

host.Run();
