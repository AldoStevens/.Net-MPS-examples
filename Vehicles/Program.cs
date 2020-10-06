using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("Black", 44, "Blue", "Male");
            Person jane = new Person("Blond", 21, "Brown", "Female" );
            jane.birthDay(45);
            john.HairColor = "Pink";

            Person aldo = new Person("Black",23, "Brown", "Male");
            aldo.birthDay(24);
            

            Person melissa = new Person("Black",21, "Brown", "Female");
            melissa.birthDay(24);
            

            Console.WriteLine("PERSON 1 has " + john.HairColor + " hair and is " + john.Age + " years old");
            Console.WriteLine("PERSON 2 has " + aldo.HairColor + " hair and is " + aldo.Age + " years old");
            Console.WriteLine("PERSON 3 has " + melissa.HairColor + " hair and is " + melissa.Age + " years old");

        }
    }
}
