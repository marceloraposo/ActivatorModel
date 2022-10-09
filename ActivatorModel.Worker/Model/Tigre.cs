namespace ActivatorModel.Worker.Model;

public class Tigre : Animal
{
    private bool Voa { get; } = false;
    private bool Nada { get; } = false;
    private bool Corre { get; } = true;
    private Comida Comida { get; } = new Comida { Carne = true, Vegetal = true };
    private bool TemNoPais { get; set; }
    public static readonly string Name = AnimalType.Tigre.ToString();

    public Tigre(bool temNoPais, Comida comida) : base(temNoPais, comida)
    {
        Comida = comida;
        TemNoPais = temNoPais;
    }
}
