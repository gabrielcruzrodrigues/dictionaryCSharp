int a = 10;
int b = 0;

try
{
    int result = a / b;
    Console.ReadKey();
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.ReadKey();
}
finally
{
    Console.WriteLine("Ação extra!");
    Console.ReadKey();
}