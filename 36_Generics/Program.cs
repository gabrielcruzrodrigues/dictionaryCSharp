/* Permite criar uma estrutura generica que aceite qualquer tipo de dado.
 * Nao podemos usar tipos genêricos em metodos static
 */
Test teste = new();

teste.Comparar(1, 2);
teste.Comparar("Alguma coisa", "Alguma coisa");
teste.Comparar(true, true);

teste.Comparar2("oi", 1);
teste.Comparar2("Alguma coisa", 1);
teste.Comparar2(true, 2);

Test2<int, int> test2 = new Test2<int, int>();
test2.Comparar(1, 2);

Test3<int, int> test3 = new Test3<int, int>();
test3.Comparar(2, 3);

public class Test
{
    public void Comparar<T>(T p1, T p2)
    {
        if (p1 is null || p2 is null)
        {
            return; 
        }
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}!");
        Console.ReadKey();
    }

    public void Comparar2<T1, T2>(T1 p1, T2 p2)
    {
        if (p1 is null || p2 is null)
        {
            return;
        }
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}!");
        Console.ReadKey();
    }
}

public class Test2<T1, T2>
{
    public void Comparar<T>(T p1, T p2)
    {
        if (p1 is null || p2 is null)
        {
            return;
        }
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}!");
        Console.ReadKey();
    }
}

/* Principais restrições usadas no generics
 * - struct _ Tipo valor
 * - class _ Tipo referencia
 * - new() _ Deve ter um construtor padrão
 * - <nome_classe_base>
 * - <nome_interface>
 */
public class Test3<T1, T2> where T1 : struct where T2 : struct //Os dois dipos desem ser valor
{
    public void Comparar<T>(T p1, T p2)
    {
        if (p1 is null || p2 is null)
        {
            return;
        }
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}!");
        Console.ReadKey();
    }
}
