using ActivatorModel.Worker.Model;

namespace ActivatorModel.Worker.Factory;

public interface IAnimalFactory
{
    Animal Create(AnimalType animalType, bool temNoPais, Comida comida);
}
