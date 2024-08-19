using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _15_Classes
{
    internal class Person
    {
        public int id;
        public string name;

        public Person() { }

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void ToString()
        {
            Console.WriteLine($"O user {name} tem o id {id}!");
        }
    }
}
