/* São funções que não possuem nome e podem ser definidas usando a palavra-chave delegate
 * e pode ser atribuída a uma variável do tipo delegate.
 * 
 * Uma função anônima é uma declaração "in-line" ou expressão que pode ser usada sempre
 * que um tipo de delgate for esperado.
 * 
 * Podemos usá-las para iniciar um delegate nomeado ou passar um método anônimo em vez de
 * um tipo de delegate nomeado como um parâmetro de método.
 * 
 * Existem dois tipos de funções anônimas
 * 1 - Métodos anônimos (Anonymous Method).
 * 2 - Expressão Lambdas(Lambdas Expressions).
 */

Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Método anônimo. Valor: {valor}.");
};

imprimir(100);

//--------------------- outro exemplo---------------------
List<string> names = ["Gabriel", "José", "Pedro"];
var result = names.Find(delegate (string name)
{
    return name.Equals("Pedro");
});
Console.WriteLine(result);
    


Console.ReadKey();

public delegate void Imprimir(int valor);