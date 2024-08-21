/* Upcasting é transformar uma classe derivada em sua classe base
 * Ao fazer o UpCasting, a classe derivada perde os atributos e métodos especializados da classe derivada
 * que não existam na classe base.
 *
 * Downcasting é transformar uma classe base em sua classe derivada
 */

Forma upCasting = new Circle(1.2, "circle"); //Upcasting

/* O operador 'as' é usado para realizar a conversão entre tipo de referência ou anuláveis;
 * retorna null se a conversão não for possível. */

//without the operator as
try
{
    Circle downCasting = (Circle)upCasting; //DownCasting
} 
catch(Exception ex)
{
    Console.WriteLine("Aconteceu um erro ao tentar executar o DownCasting: " + ex.Message);
}

//with the operator as
Circle? result = upCasting as Circle; //convert or return null, without exceptions.

/* O operador 'is' é ultilizado para verificar se um tipo é compativel com outro, retorna um booleano;
 * Podemos usar o 'is' para verificar se uma conversão será bem sucedida ou não */
bool verify = upCasting is Circle; //verifica se o obj do tipo form é compatível com o Circle.

//all flux
bool verifyType = upCasting is Circle;
if (verifyType)
{
    var newCircle = upCasting as Circle;
}


public class Forma
{
    public double Area { get; set; }

    public Forma()
    {
        
    }

    public Forma(double area)
    {
        this.Area = area;
    }
}

public class Circle : Forma
{
    public string Type { get; set; }

    public Circle(double area, string type)
    {
        this.Area = area;
        this.Type = type;
    }   

}
