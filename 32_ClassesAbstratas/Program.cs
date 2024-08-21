/* - Um método abstrato não possui impolementação na classe abstrata.
 * - Possui somente a definição de sua assinatura.
 * - É implicitamente um método virtual 
 * - A implementação do método abstrato é feita na classe derivada.
 * - As classes derivadas de uma classe abstrata são obrgadas a implementar os seus métodos abstratos.
 * - É um erro usar modificadores virtual e static em um método abstrato.
 * - As propriedades abstratas se comportam como os métodos abstratos.
 */

public abstract class Form
{
    public void Desenhar()
    { }

    //método abstrato
    public abstract double CalcularArea(); //deve ser obrigatoriamente implementado.
}
