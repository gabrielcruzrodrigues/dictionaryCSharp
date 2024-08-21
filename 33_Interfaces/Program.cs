Circle circle = new();
circle.Pintar();
circle.Desenhar();

public interface IControll
{
    void Desenhar(); //métodos abstratos que serão obrigatoriamente implementados.

    public void Exibir() //método com implementação que será herdado por classes ou interfaces,
                         //sua implementação não é obrigatória.
    {
        Console.WriteLine("Exibir");
    }
}

public interface IAction
{
    void Pintar();

    public void Manchar()
    {
        Console.WriteLine("Manchar");
    }
}

public class Circle : IControll, IAction
{
    public void Desenhar()
    {
        Console.WriteLine("Desenhar");
    }

    public void Pintar()
    {
        Console.WriteLine("Manchar");
    }
}