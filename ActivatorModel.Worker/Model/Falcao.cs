namespace ActivatorModel.Worker.Model;

public class Falcao : Animal
{
    private bool Voa { get; } = true;
    private bool Nada { get; } = false;
    private bool Corre { get; } = false;
    private Comida Comida { get; } = new Comida { Carne = true, Vegetal = true };
    private bool TemNoPais { get; set; }
    public static readonly string Name = AnimalType.Falcao.ToString();

    public Falcao(bool temNoPais, Comida comida) : base(temNoPais, comida)
    {
        Comida = comida;
        TemNoPais = temNoPais;
    }
}
