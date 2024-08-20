Printar printar = new Printar(); 
//é possível inverter a ordem dos argumentos
printar.Print(number: 1, text: "Alguma coisa");

public class Printar
{
    public void Print(string text, int number)
    {
        Console.WriteLine(text + number);
        Console.ReadKey();
    }
}

