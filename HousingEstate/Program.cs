using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Palo", "Hodás", 16);
            Person b = new Person("Miloš", "Hodás", 46);
            Person c = new Person("Pter", "Hodás", 18);
            Person d = new Person("Katarína", "Hodásová", 41);



            Flat flat = new Flat(1, "100m²", 5);
            Flat flat2 = new Flat(2, "100m²", 4);



            Console.WriteLine(flat.Tostring());
            Console.WriteLine();
            flat.AddHabitant(a, flat);
            flat.AddHabitant(b, flat);
            flat.AddHabitant(c, flat2);
            flat.AddHabitant(d, flat2);
            Console.WriteLine();
            Console.WriteLine(flat.GetInfoAboutAllHabitants());
            Console.WriteLine(a.GetInfoAboutFlat(flat));
        }
       
        
    }
}
