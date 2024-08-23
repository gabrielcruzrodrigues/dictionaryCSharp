namespace _37_GetHashCodeAndEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "oi";
            string b = "oi";
            var result = a.Equals(b); //true for value types

            Person person1 = new Person(2, "Gabriel Cruz");
            Person person2 = new Person(1, "Gabriel");
            var result2 = person1.Equals(person2); //false for reference types, because the reference is different

            /* GetHashCode retorna um valor inteiro (codigo hash) com base nas informações do objeto(estado do objeto)
             * com base nas informações do objeto(estado objeto) e é mais rápido que o método Equals.
             * 
             * Objetos diferentes sempre vão gerar um número diferente de hash
            */

            //equal values hash because are equals values;
            Console.WriteLine(a + " = " + a.GetHashCode()); 
            Console.WriteLine(b + " = " + b.GetHashCode());

            //different values hash because are different reference values
            Console.WriteLine("person1 = " + person1.GetHashCode());
            Console.WriteLine("person2 = " + person2.GetHashCode());

            //Equals values hash because are equals reference values
            Person person3 = new Person(4, "Samuel");
            Person person4 = new Person(4, "Samuel");
            Console.WriteLine("person3 = " + person3.GetHashCode());
            Console.WriteLine("person4 = " + person4.GetHashCode());
            Console.ReadKey();
        }

        public class Person
        {
            public int Id { get; set; }
            public string? Name { get; set; }

            public Person(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public override bool Equals(object? obj)  //sobrescribe the Equals method
            {
                if (obj == null)
                    return false;

                if (obj is not Person)
                    return false;

                var other = (Person)obj;

                return Name.Equals(other.Name);
            }

            public override int GetHashCode() //sobrescribe the HashCode method
            {
                return Name.GetHashCode();
            }
        }
    }
}
