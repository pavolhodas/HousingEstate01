using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat();
            flat.All();
            flat.WriteOnly();
        }
    }
}
