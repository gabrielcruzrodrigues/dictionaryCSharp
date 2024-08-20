/* Por padrão, os valores associados aos membros de uma enum são do tipo int;
 * O valor dos enuns começa a contar do zero;
 * O Enum é do tipo valor, então é armazenado na stack;
 */
int day = (int) DiasDaSemana.TERCA;
Console.WriteLine(day);
Console.ReadKey();

enum DiasDaSemana
{
    SEGUNDA, 
    TERCA,
    QUARTA,
    QUINTA,
    SEXTA,
    SABADO,
    DOMINGO
}

//enum com valores personalizados
enum CodeError
{
    NENHUM = 0,
    DESCONHECIDO = 1,
    SYSTEM_ERROR = 500,
    INVALID_DATA = 400
}

//Definindo o tipo de dados numerico dos enuns
enum Test : byte
{
    TESTE,
    TESTE1,
    TESTE2
}
