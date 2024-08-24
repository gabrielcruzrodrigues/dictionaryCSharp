/* Um delegate é um tipo que representa referências a métodos com uma lsita de parâmetros e um tipo de
 * retorno específicos.
 * 
 * Ao instanciar um delegate, podemos associar a sua instância a qualquer método com uma assinatura
 * compatível e tipo de retorno, e podemos invocar o método por meio da instância delegada.
 * 
 * Os delegates são usados para implementar eventos, métodos de retorno de chamada e para passar
 * métodos como argumentos para outros métodos.
 * 
 * Usando delegates temos a flexibilidade para implementar qualquer funcionalidade em tempo de execução.
 * 
 * Um delegate é um tipo de dados (tipo de referência) que define a assinatura de um método.
 * 
 * Podemos definir variáveis de um tipo delegate que podem se referir a qualquer método que tiverem a
 * mesma assinatura do delegate.
 * 
 * ------ etapas ---------
 * 1 - Declarar um delegate
 * 2 - Definir um método de destino
 * 3 - Invocar ou chamar um delegate
 */

var sum = Calculator.Sum(1, 2);
Console.WriteLine(sum);

// ------------------ singleCast Delegate ------------------
DelegateCalculator calc = new DelegateCalculator(Calculator.Sum);
var result = calc.Invoke(1, 2);
Console.WriteLine(result); //3

// ------------------ Multicast Delegate ------------------
DelegateCalculator2 calc2 = new DelegateCalculator2(Calculator.Sum);
calc2 += Calculator.Sub;
Console.WriteLine(calc2.Invoke(2, 2)); //4 0



//-------------------- Delegate Predicate --------------------
/* Representa um método que recebe um único argumento do tipo T e retorna um valor booleano.
 */
int x = 2;
Predicate<int> delegatePar = x => x % 2 == 0;
if (delegatePar(x))
    Console.WriteLine($"O número {x} é par!");


//-------------------- Delegate Action --------------------
/* Representa um método que não retorna valor, mas pode receber até 16 argumentos de entrada.
 */
int y = 2;
int z = 5;
Action<int, int> delegateAction = (y, z) => Console.WriteLine(y * z);
delegateAction(y, z);

//-------------------- Delegate Fun --------------------
/* Recebe de um até 16 argumentos do tipo T de entrada e retorna um valor do tipo TResult.
 */
int c = 6;
Func<double, double> delegateFunction = (x => Console.WriteLine(Math.Sqrt(x)));
delegateFunction(c);

Console.ReadKey();


// ------------------ singleCast Delegate declaration ------------------
public delegate int DelegateCalculator(int x, int y);
// ------------------ Multicast Delegate declaration ------------------
public delegate int DelegateCalculator2(int x, int y);

public class Calculator
{
    public static int Sum(int n1, int n2)
    {
        return (n1 + n2);
    }

    public static int Sub(int n1, int n2)
    {
        return (n1 >= n2) ? n1 - n2 : 0;
            
    }
}