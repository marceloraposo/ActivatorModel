namespace ActivatorModel.Worker.Model;

public abstract class Animal
{
    private bool Voa { get; }
    private bool Nada { get; }
    private bool Corre { get; }
    private Comida Comida { get; }
    private bool TemNoPais { get; set; }

    public Animal(bool temNoPais, Comida comida)
    {
        Comida = comida;
        TemNoPais = temNoPais;
    }


}
