/* A classe Dictionary representa uma coleção do tipo chave/valor e implementa a interface
 * IDictionary (e outras interfaces) que possui duas coleções no seu interior, uma para guardar
 * a chave e outra para guardar o valor.
 */

Dictionary<int, int> dict1 = new Dictionary<int, int>();
dict1.Add(1, 100);
dict1.Add(3, 300);
dict1.Add(2, 200);

try
{
    dict1.Add(1, 100);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); //duplicate key declaration
}

var result = dict1.TryAdd(1, 100); //return false because the key already exists
var resultKey = dict1.ContainsKey(3); //return true because the key exists

Console.WriteLine(dict1[1]); //out: 100 - get value using the key

var resultValue = dict1.ContainsValue(100); //true because the key 1 have the value 100
dict1[1] = 1000; //change the value using key access

try
{
    Console.WriteLine(dict1[6]);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message); //the key not exists
}

var resultGetValue = dict1.TryGetValue(6, out int value); //false because the value not exists

foreach (var item in dict1) //show keys and values
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

//sort values
var dictSort = new SortedDictionary<int, int>(dict1); 
var dictSort2 = dict1.OrderBy(x => x.Key);

foreach (var item in dictSort) //show keys and values
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}


Console.WriteLine("------------------------- SortedDictionary ---------------------------------");
SortedDictionary<int, int> sortDictionary = new SortedDictionary<int, int>();
sortDictionary.Add(1, 100);
sortDictionary.Add(3, 300);
sortDictionary.Add(2, 200);

foreach(var item in sortDictionary)
{
    Console.WriteLine($"{item.Key} - {item.Value}");

}

Console.ReadKey();