/* O params permite receber n valores como argumentos;
 * So é possível existir uma palavra-chave params na declaração do método;
 * Nenhum parametro adicional é permitido após a palavra-chave 'params'
 */

string[] values = { "algo", "mais alguma coisa", "quantos parametros eu quiser" };
Test.Print(values);

//more one option
Test.Print(new string[] { "algo", "mais alguma coisa", "quantos parametros eu quiser" });

//--- using the params, best form ---
Test.Print("algo", "mais alguma coisa", "quantos parametros eu quiser");

Console.ReadLine();

public class Test
{
    public static void Print(params string[] values) //using the params modify
    {
        foreach(string value in values)
        {
            Console.WriteLine(value);
        }
    }
}