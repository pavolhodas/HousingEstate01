using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Palo", "Hodás", "16");
            Person person2 = new Person("Jožo", "Hodás", "16");

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());

            Flat flat1 = new Flat(1, 1);
            Flat flat2 = new Flat(1, 2);
            //flat1 = person1.Flat;

            Console.WriteLine(flat1.ToString());
            Console.WriteLine(flat2.ToString());

            flat1.Persons();
        }
       
        
    }
}
