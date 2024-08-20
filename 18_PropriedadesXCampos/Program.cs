Person person = new Person();

public class Person()
{
    //apenas escrita
    public int Id { set { Id = value;  } }
    //apenas leitura
    private string Name { get; }


    //personalização dos metodos acessores
    private int age; //campo de apoio da propriedade Age;
    public int Age 
    {
        get { return age; } 
        set
        {
            if (value < 18)
                age = 18;
            else
                age = value;
        } 
    }
}
