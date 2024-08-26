using System.Threading;

public static Semaphore threadPool = new Semaphore(3, 5);
Semaphore semaphore = new Semaphore(1, 2);

Console.WriteLine("Incluiu a thread no semáforo");
semaphore.WaitOne();

Console.WriteLine("Executou o método");

//Libera a thread do semaforo
semaphore.Release();

Console.WriteLine("Liberou a thread do semáforo");
Console.ReadKey();

//--------------------- criação de thread sem semaphore ---------------------
for (int i = 0; i < 10; i++)
{
    Thread threadObj = new Thread(new ThreadStart(ProcessaOperacao));
    threadObj.Name = "Thread: " + i;
    threadObj.Start();
}

static void ProcessaOperacao()
{
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} - Entrou na sessão crítica");

    Thread.Sleep(6000);

    Console.WriteLine($"Thread {Thread.CurrentThread.Name} - Foi liberada...");
}
Console.ReadKey();

//--------------------- criação de thread com semaphore ---------------------

for (int i = 0; i < 10; i++)
{
    Thread threadObj = new Thread(new ThreadStart(ProcessarOperacaoSemaphore));
    threadObj.Name = "Thread: " + i;
    threadObj.Start();
}

static void ProcessarOperacaoSemaphore()
{
    threadPool.WaitOne();
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} - Entrou na sessão crítica");

    Thread.Sleep(6000);

    threadPool.Release();
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} - Foi liberada...");
}