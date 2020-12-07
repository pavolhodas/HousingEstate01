using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Habitant a = new Habitant("Palo", "Hodás", 16);
            Habitant b = new Habitant("Miloš", "Hodás", 46);
            Habitant c = new Habitant("Pter", "Hodás", 18);
            Habitant d = new Habitant("Katarína", "Hodásová", 41);

            Person administrator = new Person("Ferdinand", "Káblovec", 55);
            Person charwoman = new Person("Ivka", "Rýchla", 60);

            Flat flat = new Flat(1, "100m²", 5);
            Flat flat2 = new Flat(2, "100m²", 4);


            Entrace entrace1 = new Entrace(1, 4, 12);
            Entrace entrace2 = new Entrace(2, 7, 21);
            Entrace entrace3 = new Entrace(3, 9, 27);


            Console.WriteLine("ZARADENIE ČLOVEK - BYT - VCHOD:");
            flat.AddHabitant(a, flat, entrace1);
            flat.AddHabitant(b, flat, entrace2);
            flat.AddHabitant(c, flat2, entrace3);
            flat.AddHabitant(d, flat2, entrace3);

            Console.WriteLine();
            Console.WriteLine("VŠETCI OBYVATELIA BYTOV:");
            Console.WriteLine(flat.GetInfoAboutAllHabitants());
            Console.WriteLine(a.GetInfoAboutFlat(flat));

            Console.WriteLine();
            Console.WriteLine("PRACOVNÍCI:");
            Console.WriteLine("správca: " + administrator);
            Console.WriteLine("upratovačka: " + charwoman);


        }


    }
}
