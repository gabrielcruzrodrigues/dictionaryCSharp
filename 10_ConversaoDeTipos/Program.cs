/* A linguagem c# é estaticamente tipada em tempo de compilação.
 * Após uma variável ser declarada, ela não pode ser declarada novamente;
 * Também não pode ser usada para armazenar valores de outro tipo de dado;
 * A menos que este tipo de dado seja convertível para o tipo de dado da variável.(conversão de tipos).
 * 
 * ----- conversão implícita -----
 * O compilador c# converte automaticamente um tipo de dados em outro tipo (Quando a conversão entre os tipos
 * for compativel).
 * 
 * ----- conversão Explícita -----
 * A conversão tem que ser feita manualmente de forma explícita.
 */

//conversão implícita
int varInt = 100;               //int usa 4 bytes
double varDouble = varInt;      //double usa 8 bytes

/* Sempre que uma variável com a quantidade de bytes de menor valor for ser convertida
* para uma com um valor maior, a conversão será implícita, mas o processo inverso não funciona */

//conversão explícita
double varDouble1 = 12.456;     //double usa 0 bytes
int varInt2 = (int)varDouble;   //int usa 4 bytes

//Para a conversão explícita usamos o cast(), forçando a conversão para um tipo com menos bytes.

//O mesmo vale para operações
int n1 = 10;
int n2 = 4;

float result = (float) n1 / n2;

//para que o result receba o 2.5, é necessário o cast, ao contrario, ele armazenaria o valor inteiro (2).

//ToString() da classe Object retorna uma string que representa o objeto atual
//Object é o pai de todos os objetos na linguagem C#, os mesmos herdam o método toString().

//conversão de numérico para string
int valor1 = 1;
double valor2 = 2;

string v1 = valor1.ToString();
string v2 = valor2.ToString();

/* A classe Convert tem vários métodos para a conversão de tipos
 * ToBoolean()
 * ToChar()
 * ToDouble()
 * ToInt16()
 * ToInt32()
 * ToString()
 */

string v3 = Convert.ToString(valor1);

//ampliação == converter um tipo de menor capacidade para um de maior capacidade.
//estreitamento == converter um tipo de maior capacidade para um de menor capacidade.

//Quando uma conversão de estreitamento de dados resultar em perda de dados, vai ocorrer um OverflowException.
int varInt6 = 100;
byte  varByte6 = Convert.ToByte(valor2);

//toString("c") converte o valor para a moeda local.
string moedaLocal = varInt.ToString("c");