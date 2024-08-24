/* Delegates pré-definidos : EventHandler e EventHandler<TEventArgs>
 * 
 * 1 - EventHandler
 * Representa um método que vai manipular um evento que não possui dados.
 * 
 *      public delegate void EventHandler(object? sender, EventArgs e);
 *      
 *      * Object: sender: contém uma referência ao objeto que gerou o evento(fonte do evento).
 *      * e EventArgs: um objeto que não contém nenhum dado de um evento.
 *      
 * 2 - Representa um método que vai manipular um evento que possui dados
 * 
 *      public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
 *      
 *      * TEventArgs: O tipo dos dados do evento gerado pelo evento.
 *      * object? sender: Contém uma referência ao objeto que gerou o evento(fonte do evento).
 *      * TEventArgs: Um Objeto que contém os dados de um evento.
  */

var pedido = new Pedido();
pedido.OnCriarPedido += Email.Send;
pedido.CriarPedido();
Console.ReadKey();

class Pedido
{
    public event EventHandler? OnCriarPedido; //Default EventHandler

    public void CriarPedido()
    {
        Console.WriteLine("Criando pedido!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, EventArgs.Empty);
        }
    }
}

public class Email
{
    public static void Send(Object? sender, EventArgs e) //params for recive EventHandler
    {
        Console.WriteLine("Enviando email...");
    }
}