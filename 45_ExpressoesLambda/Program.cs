/* Uma expressão lambda é uma função anônima que pode ser usada para criar delegates ou 
 * expressões de árvores de expressão.
 * 
 * É uma maneira mais curta de representar um método anônimo usando a sintaxe (sugar syntax).
 */

List<string> names = ["Gabriel", "José", "Pedro"];
var result = names.Find(name => name.Equals("Pedro"));
Console.WriteLine(result);
Console.ReadKey();
