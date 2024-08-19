/* Uma variável de um tipo valor não pode conter o valor null.
 * O valor padrão de uma variável de um tipo por valor é zero.
 * Não é possível atribuir null a uma variável do tipo valor.
 * Variáveis do tipo valor são armazenadas na stack.
 * 
 * Nullable Type é um tipo de valor que pode receber um valor null.
 * São Tipos anuláveis e permitem atribuir um valor null a um tipo de valor
 * Suportam os tipos valor (int, double, float, bool... etc)
 */

//declaração de um nullable do tipo int
Nullable<int> n1 = null;

//podemos simplificar o nullable com o uso da interrogação
int? n2 = null;

//Os nullableType são diferentes do tipo valor.

//Usamos o operador de coalescência (??) para atribuir um tipo anulável para um tipo não anulável.
int? a = null;
int b = a ?? 0;

//Para realizar operações com NullableTypes, todos as variáveis devem ser do tipo NullableType.
int? nt1 = 1;
int? nt2 = 2;
int? result = 1 * 2;

//retorna true se existir um valor e false se não existir valor
bool hasValue = result.HasValue;

//retorna o valor do Nullable
int value = result.Value;