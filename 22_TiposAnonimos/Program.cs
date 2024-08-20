/* São derivados da classe Object.
 * O compilador fica responsável por criar a classe e os campos e propriedades.
 * Todas as propriedades dos tipos anônimos são apenas do tipo leitura.
 * Nenhum outro tipo de membro de classe, como métodos e eventos é válida.
 */

var Person = new
{
    Name = "Gabriel",
    Age = 22
};

Console.WriteLine(Person.Name);
Console.ReadKey();


//Um tipo anônimo com outro tipo anônimo dentro
var Student = new
{
    Name = "Gabriel",
    Address = new { Street = "Rua das Oliveiras!" }
};

Console.WriteLine($"O estudante {Student.Name} mora na rua: {Student.Address.Street}");
Console.ReadKey();

//Um array de tipos anônimos
var Students = new[]
{
    new {Id = 1, Name = "Gabriel"},
    new {Id = 2, Name = "Paula"},
    new {Id = 3, Name = "José"}
};
Console.WriteLine(Students[0].Name);
Console.ReadKey();