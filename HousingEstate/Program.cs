using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {

            Flat flat1 = new Flat(1, "100m²", 5);
            Console.WriteLine(flat1.AddHabitant());

            Console.WriteLine(flat1.persons[0].ToString());
            Console.WriteLine(flat1.GetInfoAboutAllHabitants(0));



            new Person("j ", "Hodás ", 18);
            new Person("a ", "Hodás ", 16);
            new Person("n ", "Hodás ", 46);
            new Person("o ", "Hodásová ", 41);

            Flat flat2 = new Flat(2, "150m²", 7);
            Console.WriteLine(flat2.persons[1].ToString());

            Console.WriteLine(flat2.GetInfoAboutAllHabitants(1));

            
        }
       
        
    }
}
