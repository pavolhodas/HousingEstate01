using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {

            Flat flat1 = new Flat(1, "100m²", 5);
            Console.WriteLine(flat1.persons[0].GetPersonInformation());

            Console.WriteLine(flat1.ToString(0));

            Flat flat2 = new Flat(2, "150m²", 7);
            Console.WriteLine(flat2.persons[1].GetPersonInformation());

            Console.WriteLine(flat2.ToString(1));
        }
       
        
    }
}
