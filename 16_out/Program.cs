Somar somar = new Somar();
int a = 1;

int soma = somar.SomarDoisNumeros(a, out int b);
Console.WriteLine(b);
Console.ReadKey();

public class Somar()
{
    public int SomarDoisNumeros(int a, out int b)
    {
        b = 2;
        return (a + b);
    }
}