using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Entrance
    {
        public List<string> NumberOfRightEntrance = new List<string>() { "2, 4, 6, 8, 10, 12" };
        public List<string> NumberOfLeftEntrance = new List<string>() { "1, 3, 5, 7, 9, 11"};
        public void PairedEntrance()
        {
            Console.WriteLine(NumberOfRightEntrance[0]);
        }
        public void UnPairedEntrance()
        {
            Console.WriteLine(NumberOfLeftEntrance[0]);
        }
    }
}
