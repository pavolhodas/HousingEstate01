using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat : Person
    {
        private List<int> numberOfFlat = new List<int> { 1, 2, 3, 4 };
        private List<string> listOfPerson = new List<string> { "Palino", "Peto", "Katka", "Miloš" };

        public List<int> NumberOfFlat
        {
            get { return numberOfFlat; }
            set { numberOfFlat = value; }
        }
        public void All()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(numberOfFlat[i] = i++);
            }
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(listOfPerson[i]);
            }

        }
        public void WriteOnly()
        {
        Console.WriteLine($"V panelaku č.{numberOfFlat[0]} býva {listOfPerson[0]}");

       }
    }
}
