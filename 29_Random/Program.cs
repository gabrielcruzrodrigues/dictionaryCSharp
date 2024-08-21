Random random = new(); // -> Semente padrão usando o relógio do sistema
Random random1 = new Random(5123); // -> Semente personalizada

//Next retorna um número inteiro aleatório positivo dentro do intervalo padrão
random.Next();

//Next(int) retorna um número interior aleatório positivo que é menor que o valor máxomo definido
random.Next(10);

//Next(int, int) retorna um número inteiro aleatório positivo dentro do intervalo mínimo e máximo definido (inclui o mínimo e exclui o máximo);
random.Next(10, 20);

//NextDouble() Gera um número de ponto flutuante aleatório que é maior ou igual o 0,0 e menor que 1,0
random.NextDouble();

//NextByte(Byte[]) Preenche os elementos de um array de butes com números aleatórios
random.NextBytes(new byte[10]);

//NextInt64() Retorna um número inteiro aleatório positivo dentro do intervalo 0 e 92233...
random.NextInt64();