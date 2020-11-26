using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Palo ", "Hodás ", 18);
            Person b = new Person("Miloš ", "Hodás ", 16);
            Person c = new Person("Pter ", "Hodás ", 46);
            Person d = new Person("Katarína ", "Hodásová ", 41);



            Flat flat = new Flat(1, "100m²", 5);


            Console.WriteLine(a.ToString());
            Console.WriteLine(flat.Tostring());
            Console.WriteLine();
            flat.AddHabitant(a);
            flat.AddHabitant(b);
            flat.AddHabitant(c);
            flat.AddHabitant(d);

        }
       
        
    }
}
