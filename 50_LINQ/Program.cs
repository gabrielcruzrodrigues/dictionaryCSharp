/* Language-Integrated Query é um conjunto de tecnologias baseada na integração de recursos de
 * consulta diretamente na linguagem C#;
 * 
 * Permite escrever consultas em coleções fortemente tipadas usando palavras-chave da linguagem
 * C#, operadores familiares e com o suporte ao IntelliSense.
 * 
 * Fornece uma sintaxe de consulta baseada na linguagem de consulta padrão do SQL e uma experiência
 * de consulta consistente para objetos, bancos de dados relacionais, XML e diversas fontes de dados.
 * 
 * --------------- recursos ---------------
 * 
 * Expressões de consulta - usa uma sintaxe declarativa semelhante ao SQL para consultar em coleções IEnumerable.
 * 
 * Métodos de Extensão - Os operadores de consulta padrão da LINQ são um conjunto de métodos de extensão
 * que fornecem a funcionalidade de consulta para qualquer tipo que implementa IEnumerable<T>
 * 
 * Expressões lambda
 * 
 * Tipos anônimos
 * 
 * Variáveis tipas implicitamente
 * 
 * inicializadores de objeto e coleção
 */

List<string> names = ["Gabriel", "Nathan", "Pedro", "Júlia", "Guiberto"];

//IEnumerable
var result = from m in names           //Query sintax
             where m.Contains('P')
             select m;

//List<T>
var result2 = names.Where(m => m.Contains('G')) //Method synta
               .Select(m => new
               {
                   Name = m
               })
               .OrderBy(m => m.Name);

foreach(var item in result)
{
    Console.WriteLine(item);
}

foreach (var item in result2)
{
    Console.WriteLine(item.Name);
}

Console.ReadKey();
