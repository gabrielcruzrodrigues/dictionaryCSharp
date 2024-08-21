//Default initialize
List<string> list = new List<string>();
list.Add("Alguma coisa!");

//new sintaxe for declaration
List<int> numbersList = new()
{
    4, 3, 2, 1
};

numbersList.Sort();

foreach (int number in numbersList)
{
    Console.WriteLine(number);
}

Console.ReadKey();

//Boxing é a conversão de um Value Type para um Reference Type.
//Unboxing é quando um Reference Type (Object) volta a ser um Value Type. 
int num = 23;
Object obj = num; //Boxing
int i = (int)obj; //Unboxing

/* O ArrayList faz o Boxing toda vez que um tipo valor ou referencia é armazenado dentro dele
 * e faz o Unboxing quando os valores são recuperados. Essa operação degrada o desempenho. */

//O tipo List não realiza o Boxing nem o Unboxing, pois ele trabalha com os tipos valor.

List<string> frutas = new()
{
    "maça", "pera", "laranja"
};

//method find without lambda
var fruta1 = frutas.Find(Verify);
Console.WriteLine(fruta1);

static bool Verify(string fruta)
{
    return fruta.StartsWith('l');
}

/* Predicado é uma função que a partir de uma expressão retorna verdadeiro ou falso conforme
 * a lógica da expressão definida na função */

//A função lambda serve para substituir os predicados.

//method find with lambda
var fruta2 = frutas.Find(fruta => fruta.StartsWith('l'));
Console.WriteLine(fruta2);


//IEnumerable<t> é uma interface apenas de leitura.

//O methodo Where retorna um IEnumerable.
var frutasWithWordA = frutas.Where(fruta => fruta.Contains('a')).ToList();
ShowFrutas(frutasWithWordA);

static void ShowFrutas(List<string> frutas)
{
    foreach (string fruta in frutas)
    {
        Console.WriteLine(fruta);
    }   
    Console.ReadKey();
}