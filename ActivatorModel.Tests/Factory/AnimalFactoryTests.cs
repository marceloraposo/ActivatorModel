using ActivatorModel.Worker.Model;
using Xunit;
using Moq;
using ActivatorModel.Worker.Factory;

namespace ActivatorModel.Tests.Factory;

public class AnimalFactoryTests
{
    [Theory]
    [InlineData(AnimalType.Baiacu, true)]
    [InlineData(AnimalType.Falcao, true)]
    [InlineData(AnimalType.Tigre, true)]
    [InlineData(AnimalType.Baiacu, false)]
    [InlineData(AnimalType.Falcao, false)]
    [InlineData(AnimalType.Tigre, false)]    
    public void ShouldReturnAnimalActivatorUtilities(AnimalType animalType, bool temNoPais)
    {
        Comida comida = new Comida { Carne = false, Vegetal = true };

        var serviceProviderMock = new Mock<IServiceProvider>();

        var animalFactory = new AnimalFactory(serviceProviderMock.Object);

        var result = animalFactory.Create(animalType, temNoPais, comida);

        Assert.NotNull(result);
    }

    [Theory]
    [InlineData(AnimalType.Baiacu, true)]
    [InlineData(AnimalType.Falcao, true)]
    [InlineData(AnimalType.Tigre, true)]
    [InlineData(AnimalType.Baiacu, false)]
    [InlineData(AnimalType.Falcao, false)]
    [InlineData(AnimalType.Tigre, false)]    
    public void ShouldReturnAnimalWithActivator(AnimalType animalType, bool temNoPais)
    {
        Comida comida = new Comida { Carne = false, Vegetal = true };

        var serviceProviderMock = new Mock<IServiceProvider>();

        var animalFactory = new AnimalFactory(serviceProviderMock.Object);

        var result = animalFactory.CreateActivator(animalType, temNoPais, comida);

        Assert.NotNull(result);
    }    
}