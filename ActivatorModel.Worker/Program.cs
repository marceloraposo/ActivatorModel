using ActivatorModel.Worker;
using ActivatorModel.Worker.Factory;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddScoped<IAnimalFactory,AnimalFactory>();
    })
    .Build();

await host.RunAsync();
