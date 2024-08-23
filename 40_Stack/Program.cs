/* Stack é uma coleção genérica de tamanho variável que funciona com base no princípio LIFO
 * (last in fist out), e está presente no namespace System.collections.Generic.
 * 
 * Pode ter elementos duplicados e pode aceitar null.
 */

//constructors

Stack<string> diasSemana = new Stack<string>();
diasSemana.Push("Segunda");
diasSemana.Push("Terça");

int[] numbers = [1, 2, 3, 4, 5];
Stack<int> numbersStack = new Stack<int>(numbers);

var capacityStack = new Stack<int>(5);

//retorna sem remover
diasSemana.Peek();

//retorna e remove
diasSemana.Pop();