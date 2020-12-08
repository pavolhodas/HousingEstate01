using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Entrace
    {
        private int nameOfEntrace;
        private int numberOfFloors;
        private int numberOfFlats;
        public Entrace(int NameOfEntrace,int NumberOfFloors, int NumberOfFlats)
        {
            nameOfEntrace = NameOfEntrace;
            numberOfFloors = NumberOfFloors;
            numberOfFlats = NumberOfFlats;
        }
        public string GetInfoAboutEntrace()
        {
            if (nameOfEntrace%2 == 0)
            {
                return "Side of road: R";
            }
            else
            {
                return "Side of road: L";
            }
        }
        public override string ToString()
        {
            return $"{nameOfEntrace}, {numberOfFloors}, {numberOfFlats}, {GetInfoAboutEntrace()}";
        }
    }
}
