/* Consideramos usar uma struct em vez de uma classe se as instâncias do tipo forem pequenas
 * e normalmente de curta duração, ou se forem comumente incorporadas em outros objs.
 * 
 * --------- Evitar definir um struct se: ---------
 * 
 * Representa logicamente um único valor, semelhante aos tipos primitivos (int, double, etc).
 * Tem um tamanho de instância inferior a 16 bytes.
 * É imutável.
 * Não precisá sofrer conversão para tipo de referência (boxing) com frequência.
 */

Person person = new Person();
person.Name = "Teste";
Console.WriteLine(person.Name);
Console.ReadKey();

public struct Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Person(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}


