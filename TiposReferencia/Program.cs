/* São tipos de referência.
 * O valor padrão é null.
 */

//Representa uma sequência de zero ou mais caracteres Unicode(São Imutáveis);
//As strings são imutáveis, depois de declaradas não podem ser alteradas;
string phase = "Hello world!";
System.String phase2 = "Hello world 2!";

//É o tipo base para todos os outros tipos;
//Aceita todos os outros tipos de dados;
object obj = true;

//São resolvidos em tempo de execução;
//Se comporta como o tipo object na maioria das situações;
//Aceita todos os outros tipos de dados;
dynamic obj2 = true;