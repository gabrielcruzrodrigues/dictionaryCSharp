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
;

        //passagem de argumento por valor
        int n1 = 0;
        string s1 = "Fiesta";
        car.SpeakNumber(n1);

        //passagem de argumento por referência
        car.addStringToModel(ref s1);
        Console.WriteLine(s1);

        Console.ReadKey();
    }
}

class Car
{
    public int id {  get; set; }
    public string? model {  get; set; }
       
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

    public void addStringToModel(ref string str)
    {
        str = "outra coisa";
    }
}