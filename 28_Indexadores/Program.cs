/* Os indexadores permitem que as instâncias de uma classe ou struct sejam indexadas como
 * um array. Eles lembram as propriedades mas seus acessores (get, set) recebem parâmetros.
 * 
 * Um indexador é um membro da classe que permite acessar uma variável de membro da classe
 * ou struct usando os recursos de um array.
 * 
 * Quando definimos um indexador para uma classe, essa classe se comporta como um array virtual
 * e podemos acessar a instância da classe usando o operador de acesso ao array [] e também
 * usar índices para acessar e atribuir valores como nos arrays. */


/* Posso inserir ou recuperar dados nos locais específicos do meu array dentro da minha instância 
 * de classe de forma simples*/
Time time = new();
time[0] = "Palmeiras";
time[1] = "Santos";

string time1 = time[0];
string time2 = time[1]; 

public class Time
{
    string[] valor = new string[10]; 

    public string this[int i] //uso da palavra this
    {
        get
        {
            if (i >= 0 && i < valor.Length)
            {
                return valor[i];
            }
            return "Erro";
        }
        set
        {
            if (i >= 0 && i < valor.Length)
            {
                valor[i] = value;
            }
        }
    }
}