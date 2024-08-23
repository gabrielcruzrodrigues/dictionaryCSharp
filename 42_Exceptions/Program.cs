
try
{
    //exception
} 
catch(Exception ex)
{
    throw new Exception("Manual exception");
}

try
{
    //exception
}
catch (Exception ex) when (ex.Message.Contains("format")) //exception with filters
{
    throw new Exception("Manual exception");
}

public class MyException : Exception //custom exception
{
    public MyException() { }

    public MyException(string message) : base(message) { }

    public MyException(string message, Exception inner) : base(message, inner) { }

    public override string Message
    {
        get 
        {
            return "Minha mensagem personalizada";
        }
    }

    public override string? HelpLink 
    {
        get
        {
            return "http://algumlink.com";

        }
    }
}
