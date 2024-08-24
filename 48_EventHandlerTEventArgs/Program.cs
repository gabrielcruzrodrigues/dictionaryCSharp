using Microsoft.VisualBasic;

var pedido = new Pedido();
pedido.OnCriarPedido += SMS.Send;
pedido.CriarPedido("gabriel@test.com", "00000000000");
Console.ReadKey();

class Pedido
{
    public event EventHandler<PedidoEventArgs> OnCriarPedido;

    public void CriarPedido(string email, string sms)
    {
        Console.WriteLine("Criando pedido");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email = email, SMS = sms});
        }
    }
}

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? SMS { get; set; }
}

class SMS
{
    public static void Send(Object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Send SMS for {e.SMS} - user: {e.Email}");
    }
}
