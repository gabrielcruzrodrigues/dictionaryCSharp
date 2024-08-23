/* É uma coleção genérica de tamanho variável que funciona com base no princípio FIFO 
 * (first in fist out), e esta presente no namespace System.Collections.Generic;
 * 
 * Esta coleção contém os elementos na ordem em que foram adicionados e serão removidos
 * nesta ordem. Um item incluído primeiro será removido primeiro.
 * 
 * Permite valores duplicados e nulos.
 */

//Constructors

Queue<string> diasSemana = new Queue<string>();
diasSemana.Enqueue("Segunda");
diasSemana.Enqueue("Terça");

string[] texts = ["alguma", "coisa", "para", "testar"];
Queue<string> textsQueue = new Queue<string>(texts);

var queue = new Queue<string>(5);

//Remover elemento
diasSemana.Dequeue();
