/* São mecanismos que permitem que uma classe ou objeto notifique outras classes ou objetos quando 
 * alguma ação ocorre.
 * 
 * A classe que envia (ou aciona) o evento é chamada de Publisher ou Publicador, e as classes que
 * recebem (ou manipulam) os eventos são chamadas de Subscribers ou Assinantes.
 * 
 * - Podem haber vários assinantes de um único evento.
 * - Um publicador, quase sempre, gera um evento quando alguma ação ocorre.
 * - Os assinantes, que estão interessados em receber uma notificação quando uma ação ocorrer,
 * devem se registrar em um evento e tratá-lo.
 * - E os métodos das classes que manipulam o evento(Subscribers) geralmente são chamados de manipuladores
 * de eventos.
 */


Console.WriteLine("Usando o evento OnCriarPedido");

var pedido = new Pedido();
pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.SendSMS;
pedido.CriarPedido();
Console.ReadKey();

delegate void PedidoEventHandler();

class Pedido
{
    public event PedidoEventHandler? OnCriarPedido; // declarando evento e associando ao delegate.

    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

public class Email
{
    public static void Send()
    {
        Console.WriteLine("Enviando email....");
    }
}

public class SMS
{
    public static void SendSMS()
    {
        Console.WriteLine("Enviando SMS...");
    }
}