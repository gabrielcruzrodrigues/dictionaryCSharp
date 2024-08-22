/* As classes derivadas de uma mesma classe base podem invocar métodos que tem a mesma 
 * assinatura mas comportamentos distintos, que são especializados para cada classe derivada,
 * usando para tanto uma refer^Çencia a um objeto do tipo da classe base.
 * /
 * 
 * ------------- tipos de polimorfismo -------------
 * 
 * 1 - Polimorfismo em tempo de compilação (Overloading ou Sobrecarga);
 *  - Ultiliza a sobrecarga de métodos e operadores sendo também chamado de ligação precoce
 *  (early binding). A utilização da sobrecarga(overloading) de métodos realiza a tarefa com
 *  distintos parâmetros de entrada.
 *  - Permite que classes forneçam diferentes implementações de métodos que são chamados pelo mesmo nome.
 *  
 * 2 - Polimorfismo em tempo de execução (Overriding ou Sobrescrita);
 *  - Pode ser feito usando herança e métodos virtuais. Quando sobrescrevemos(override) os métodos virtuais
 *  estamos alterando o comportamento dos métodos para a classe derivada. Isto também é conhecido como ligação tardia(late binding).
 *  
 *  ----------------------------- Polimorfismo com herança (dinamico) ----------------------------- */
Console.WriteLine("---------------------------- Polimorfismo com herança ------------------------------");

var figuras = new List<Figura>
{
    new Triangle(),
    new Circle()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}
Console.ReadKey();


/* ----------------------------- Polimorfismo com sobrecarga(estatica) -----------------------------*/
Console.WriteLine("---------------------------- Polimorfismo com sobrecarga ------------------------------");
Calcular calc = new();

calc.Somar(1, 2);
calc.Somar(1, 2, 3);
Console.ReadKey();


public class Figura
{
    public virtual void Desenhar() //polimorfismo
    {
        Console.WriteLine("Desenhando uma figura.");
    }
}

public class Circle : Figura
{
    public override void Desenhar() //polimorfismo
    {
        Console.WriteLine("Desenhando um circulo.");
        base.Desenhar();
    }
}

public class Triangle : Figura
{
    public override void Desenhar() //polimorfismo
    {
        Console.WriteLine("Desenhando um Triangulo.");
        base.Desenhar();    
    }
}

public class Calcular()
{
    public void Somar(int num1 , int num2) //polimorfismo
    {
        Console.WriteLine(num1 + num2);
    }

    public void Somar(int num1, int num2, int num3) //polimorfismo
    {
        Console.WriteLine(num1 + num2 + num3);
    }
}