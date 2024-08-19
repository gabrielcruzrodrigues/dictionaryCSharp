//O operador unitário (+) retorna o próprio valor;
int n1 = 1;
int result = +n1; //result = 1

//O operador unitário (-) retorna o negativo do valor;
int n2 = 1;
int result2 = -n2; //result = -1

//Operador ternário em uso real
Console.WriteLine("Informe a temperatura: \n");
int temp = Convert.ToInt32(Console.ReadLine());

var resultado = temp > 27 ? "quente" : "frio";

Console.WriteLine($"O clima está {resultado}");