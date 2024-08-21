/* A Composição e Agregação são técnicas de programação que permitem que uma classe "contenha"
   um ou mais objetos de outras classes para formar um grande objeto realizando algumas funcionalidades específicas.

   O contêiner é a superclasse ou classe pai e as classes contidas na superclasse são subclasses
   ou classes filhas, onde a classe pai (superclasse) e as filhas (subclasse) possuem um relacionamento "tem um".
 */


/* Um relacionamento de composição occore quando um objeto de uma classe é composto de um ou
 * mais objetos de outras classes. 
 * 
 * Este relacionamento é formado quando uma classe tem uma referência a outra classe como uma propriedade de instância.
 * 
 * Na composição, uma classe que contém a referência a outra classe é a classe pai sendo a proprietária
 * da classe filha, e a classe filha não existe sem a classe pai.
 * 
 * Representa uma relação Todo-parte
 *      - O objeto todo(pai) é responsável por criar e destruir as suas partes(filhas)
 *      - A parte(filha) não existe sem o todo(pai)
 *      - Um mesmo objeto-parte não pode se associar a mais de um objeto-Todo
 */
public class Casa
{
    private readonly Telhado _telhado;      //composição
    private readonly Alicerce _alicerce;    //composição

    public Casa()
    {
        _telhado = new Telhado();
        _alicerce = new Alicerce();
    }
}

public class Telhado
{

}

public class Alicerce
{

}

/* Um relacionamento de agregação é um tipo especial de composição onde objetos de uma classe
 * podem conter um ou mais objetos de outra classe.
 * 
 * É um relacionamento do tipo: "tem um".
 * Representa uma relação Todo-parte.
 *      - A parte e o todo são independentes.
 *      - A parte pode existir sem o todo.
 *  */

public class Departament
{
    public string? Name { get; set; }
    public List<Teacher> Teachers { get; set; } //agregação

    public void AddTeacher(Teacher teacher)
    {
        Teachers?.Add(teacher);
    }
}

public class Teacher
{
    public string? Name { get; set; }
    public string? Discipline { get; set; }
}