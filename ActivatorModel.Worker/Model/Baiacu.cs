namespace ActivatorModel.Worker.Model;

public class Baiacu : Animal
{
    private bool Voa { get; } = false;
    private bool Nada { get; } = true;
    private bool Corre { get; } = false;
    private Comida Comida { get; } = new Comida { Carne = false, Vegetal = true };
    private bool TemNoPais { get; set; }
    public static readonly string Name = AnimalType.Baiacu.ToString();

    public Baiacu(bool temNoPais, Comida comida) : base(temNoPais, comida)
    {
        Comida = comida;
        TemNoPais = temNoPais;
    }
}
