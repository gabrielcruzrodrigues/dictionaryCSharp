/* Permitem estender a funcionalidade de um tipo existente sem cirar um novo tipo derivado, 
 * recompilar ou modificar o tipo original.
 * 
 * São um tipo especial de método estático chamado como se fosse um método de instância no tipo estendido.
 * 
 * Eles são úteis para estender a funcionalidade de tipos exitentes, como classes da biblioteca padrão
 * ou classes definidas por outras bibliotecas de terceiros.
 */

string name = "Gabriel";
string invertedString = name.InvertString();
Console.WriteLine(invertedString);
Console.ReadKey();

public static class StringExtensions
{
    public static string InvertString(this string str) //esse método será uma extensão para o tipo string
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}