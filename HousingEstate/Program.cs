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


            Entrace entrace1 = new Entrace(1, 7, 14);
            Entrace entrace2 = new Entrace(2, 7, 14);
            Entrace entrace3 = new Entrace(3, 7, 14);
            Entrace entrace4 = new Entrace(4, 7, 14);

            BlockOfFlats blockOfFlats1 = new BlockOfFlats("A1", "Štefániková");
            BlockOfFlats blockOfFlats2 = new BlockOfFlats("A2", "Záriečská");

            HausingEstate hausingEstate = new HausingEstate("Vlčince");


            Console.WriteLine(hausingEstate.ToString());
            Console.WriteLine();

            Console.WriteLine("ZARADENIE ČLOVEK - BYT - VCHOD:");
            Console.WriteLine("zadajte stranu na ktorej je byt- L, R");
            Console.WriteLine(hausingEstate.AddHabitant(a, flat, entrace1, entrace3, blockOfFlats1));
            Console.WriteLine(hausingEstate.AddHabitant(b, flat, entrace2, entrace4, blockOfFlats2));
            

            Console.WriteLine();
            Console.WriteLine("VŠETCI OBYVATELIA BYTOV:");
            Console.WriteLine(flat.GetInfoAboutAllHabitants());

            Console.WriteLine();
            Console.WriteLine("ZARADOVANIE OBYVATELOV DO BYTOV:");
            Console.WriteLine(a.GetInfoAboutFlat(a, flat));

            Console.WriteLine();
            Console.WriteLine("PRACOVNÍCI:");
            Console.WriteLine("správca: " + administrator);
            Console.WriteLine("upratovačka: " + charwoman);

            Console.WriteLine();
            Console.WriteLine(blockOfFlats1.ToString());
        }
    }
}
