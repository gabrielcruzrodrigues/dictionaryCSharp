using _23_PartialClass;

/* Todas as partes parciais devem estar no mesmo namespace;
 * Todas as partes devem ter a mesma acessibilidade (public, private)
 * O modificador partial somente pode ser usado antes da palabra-chave class, struct ou interface
 * Tipos parciais aninhados são permitidos;
 * Os atributos se aplicam a todas as partes das classes;
 */

//Juntando as duas classes
PartialClass partialClass = new PartialClass();
partialClass.Print();
Console.ReadKey();