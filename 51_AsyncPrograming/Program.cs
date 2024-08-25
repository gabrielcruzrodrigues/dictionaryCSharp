/* Chamando os dois métodos de uma só vez, mas esperando o resultado estar nas variáveis para
 * poder printar na tela.
  */

var value1 = Calculator.Somar(1, 2);
var value2 = Calculator.Somar(1, 2, 3);
Console.WriteLine("Iniciando Tasks");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(await value1);
Console.WriteLine(await value2);



//cancelamento de task
CancellationTokenSource cancelaTokenSource = new CancellationTokenSource();
cancelaTokenSource.Cancel();
try //sempre usamos o tryCatch na chamada do método async estar dentro do contexto e ser tratado
    //Só conseguimos capturar a exeção lançada e armazenada no Obj Task quando usamos o await.
{
    Console.WriteLine(await OperacaoLongaDuracao(100, cancelaTokenSource.Token));
}
catch (TaskCanceledException ex)
{
    Console.WriteLine($"{ex.Message}");
}

Console.ReadKey();

static Task<int> OperacaoLongaDuracao(int valor, CancellationToken cancellationToken = default)
{
    Task<int> task = null;
    task = Task.Run(() =>
    {
        int resultado = 0;
        for (int i = 0; i < valor; i++)
        {
            if (cancellationToken.IsCancellationRequested)
                throw new TaskCanceledException(task);

            Thread.Sleep(10);
                resultado += i;
        }
        return resultado;
    });
    return task;
}

// -------------------------------- primeiro exemplo --------------------------------

public class Calculator
{
    public static async Task<int> Somar(int n1, int n2)
    {
        await Task.Delay(2000);
        Console.WriteLine("Somar with task");
        return n1 + n2;
    }

    public static async ValueTask<int> Somar(int n1, int n2, int n3)
    {
        await Task.Delay(2000);
        Console.WriteLine("Somar with ValueTask");
        return n1 + n2 + n3;
    }
}