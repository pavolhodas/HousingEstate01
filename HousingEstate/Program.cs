using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("Palo", "Hodás", "16");
            //Person person2 = new Person("Jožo", "Hodás", "18");

            //Console.WriteLine(person1.ToString());
            //Console.WriteLine(person2.ToString());

            //Flat flat1 = new Flat(1);
            //Flat flat2 = new Flat(2);

            //Console.WriteLine(person1.ToString() + flat1.ToString());
            //Console.WriteLine(person2.ToString() + flat2.ToString());

            //Entrance entrance = new Entrance();
            //entrance.UnpairedEntrance();

            Flat flat = new Flat();
            while (true)
            {
                Console.WriteLine("Napíš meno");
                string input = Console.ReadLine();
                flat.FindPersonBy(input);
            }
            //Person person = new Person("", "", 15);
            //person.GetInfo();
            
        }
       
        
    }
}
