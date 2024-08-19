using _15_Classes;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person(1, "Gabriel");
        person.ToString();
        Console.WriteLine("========================================");
        Car car = new Car(1, "Fiesta!");
        car.ToString();

        Console.ReadKey();

        //passagem de argumento por valor
        int n1 = 0;
        car.SpeakNumber(n1);
    }
}

class Car
{
    public int id;
    public string? model;
       
    public Car(int id, string? model)
    {
        this.id = id;
        this.model = model;
    }

    public void ToString()
    {
        Console.WriteLine($"O carro {this.id} é do modelo {this.model}");
    }

    public void SpeakNumber(int number)
    {
        Console.WriteLine(number);
    }
}