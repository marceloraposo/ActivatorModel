using ActivatorModel.Worker.Model;
using ActivatorModel.Worker.Factory;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace ActivatorModel.Console;
public class ActivatorPerformance
{
    private readonly Animal animal;
    private readonly Animal animalActivator;
    private readonly IServiceProvider _serviceProvider;
    public ActivatorPerformance()
    {
        _serviceProvider = new ServiceCollection()
            .AddLogging()
            .AddSingleton<IAnimalFactory, AnimalFactory>()
            .BuildServiceProvider();

        animal = ShouldReturnAnimalActivatorUtilities();
        animalActivator = ShouldReturnAnimalActivator();
    }

    [Benchmark]
    public Animal ShouldReturnAnimalActivatorUtilities()
    {
        AnimalType animalType = AnimalType.Baiacu;

        bool temNoPais = true;

        Comida comida = new Comida { Carne = false, Vegetal = true };

        var animalFactory = new AnimalFactory(_serviceProvider);

        var result = animalFactory.Create(animalType, temNoPais, comida);

        return result;
    }  

    [Benchmark]
    public Animal ShouldReturnAnimalActivator()
    {
        AnimalType animalType = AnimalType.Baiacu;

        bool temNoPais = true;

        Comida comida = new Comida { Carne = false, Vegetal = true };

        var animalFactory = new AnimalFactory(_serviceProvider);

        var result = animalFactory.CreateActivator(animalType, temNoPais, comida);

        return result;
    }    

}
