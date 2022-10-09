using ActivatorModel.Worker.Model;
using Microsoft.Extensions.DependencyInjection;

namespace ActivatorModel.Worker.Factory;

public class AnimalFactory : IAnimalFactory
{
    private readonly IServiceProvider _serviceProvider;

    public AnimalFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }    
    private static readonly Dictionary<string, Type> _animalTypes = new Dictionary<string, Type>()
    {
        { Baiacu.Name, typeof(Baiacu) },
        { Falcao.Name, typeof(Falcao) },
        { Tigre.Name, typeof(Tigre) }
    };

    public Animal Create(AnimalType animalType, bool temNoPais,  Comida comida)
    {
        var type = GetType(animalType);
        if(type == null) return null;

        return (Animal)ActivatorUtilities.CreateInstance(_serviceProvider,type, new object[] { temNoPais, comida } );
    }

    public Animal CreateActivator(AnimalType animalType, bool temNoPais,  Comida comida)
    {
        var type = GetType(animalType);
        if(type == null) return null;

        return (Animal)Activator.CreateInstance(type, new object[] { temNoPais, comida } );
    }    

    public Type GetType(AnimalType animalType)
    {
        if(!_animalTypes.ContainsKey(animalType.ToString()))
            return null;

        return _animalTypes[animalType.ToString()];
    }
}
