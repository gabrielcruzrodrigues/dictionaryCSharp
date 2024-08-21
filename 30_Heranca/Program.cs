/* -------------- tipos de herança --------------
 * Simples: é o tipo de herança em que há uma classe base e uma classe derivada.
 * Hierárquica: Onde duas ou mais classes derivadas herdam da classe base.
 * Multinível: Ocorre quando uma classe derivada é derivada de outra classe derivada.
 * Multipla: Ocorre quando temos uma classe base e uma classe derivada que implementa uma ou mais interfaces. */

Employee employee = new(1, "Gabriel", "Ti");

employee.ToWrite();
employee.TalkHi();

Console.ReadKey();

public sealed class UpPerson { } //usando o sealed para que essa classe não possa ser herdada

public class Person
{
    protected int Id { get; set; }
    protected string? Name { get; set; }

    public Person() { }

    public Person(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public void TalkHi()
    {
        Console.WriteLine("Hi!");
    }

    public virtual void TalkText() //usando virtual para sinalizar que esse metodo sera reescrito
    {
        Console.WriteLine("Text!");
    }

    public virtual void TextForSealed()
    {
        Console.WriteLine("sealed");
    }
}

public class Employee : Person //relacionamento 'é um' entre uma classe base e uma classe derivada
{
    public string? Category;  

    public Employee(int id, string name, string category) : base() //invocando o construtor da classe base
    {
        this.Id = id;
        this.Name = name;
        this.Category = category;
    }

    public new void TalkHi() //usando new para sobrescrever o metodo da classe base
    {
        Console.WriteLine("Alguma coisa");
    }

    public void ToWrite()
    {
        Console.WriteLine($"{Id} - {Name} - {Category}");
    }

    public override void TalkText() //sobrescrevendo o método virtual da classe base
    {
        Console.WriteLine("Alguma coisa diferente");
    }

    public sealed override void TextForSealed() //usando o sealed para impedir que esse metodo seja sobrescrito em outras sub-classes
    {
        Console.WriteLine("Sobrescrevendo metodo TextForSealed.");
    }
}
