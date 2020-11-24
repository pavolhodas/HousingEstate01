using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat1 = new Flat(1, "100m²", 5, "Palo", "Hodás", 16);
            Console.WriteLine(flat1.ToString());

            Flat flat2 = new Flat(2, "150m²", 7, "Peter", "Hodás", 18);
            Console.WriteLine(flat2.ToString());
        }
       
        
    }
}
