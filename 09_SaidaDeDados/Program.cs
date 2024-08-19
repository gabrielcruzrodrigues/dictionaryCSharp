int idade = 22;
string name = "Gabriel";

//Saida padrão, escrevendo cada resultado em uma linha e pulando uma linha no final
Console.WriteLine(name);
Console.WriteLine(idade);

//escreve tudo na mesma linha, e se mantem na mesma linha ao final.
Console.Write(name);

//mantem o programa parado até o proximo clique.
Console.ReadLine();

//concatenação
Console.WriteLine(name + " tem" + idade + " anos.");
Console.Write(name + " tem " + idade + " anos.\n");

//interpolação
Console.WriteLine($"{name} tem {idade} anos!");

//placeHolders
Console.WriteLine("{0} tem {1} anos!", name, idade);

//A barra invertida "\" é uma sequência de escape inválida dentro de uma string;
//Aspas duplas "" tambem são um escape inválido dentro de uma string;

/* tabela de sequeência de escapes
 * \a sinal sonoro (alerta) 
 * \b backspace
 * \f alimentação de formulário
 * \n nova linha
 * \r carriage return
 * \t tabulação horizontal
 * \v tabulação vertical
 * \' aspas simples
 * \" aspas duplas
 * \\ barra invertida
 * \? interrogação
 * \u 0000 Caractere ASCII na notação unicode
 * \x hh Caractere ASCII na notação hexadecimal
 */
