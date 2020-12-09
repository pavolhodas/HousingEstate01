using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class HausingEstate
    {

        private string nameOfHausingEstate { get; }

        public HausingEstate(string NameOfHausingEstate)
        {

            nameOfHausingEstate = NameOfHausingEstate;
        }
        public override string ToString()
        {
            return $"Sídlisko: {nameOfHausingEstate}";
        }
        public string AddHabitant(Habitant habitant, Flat flat, Entrace entrace1, Entrace entrace2, BlockOfFlats blockOfFlats)
        {
            return habitant + "  -  " + blockOfFlats.ToString() + "  -  " + "Vchody: " + entrace1.ToString() + "  -  " + entrace2.ToString() + ", " + "Byt: " + flat.Tostring();
        }
    }
}
