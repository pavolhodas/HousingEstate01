using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        private int numberOfFlat { get; }
        private string area { get; }
        private int numberOfRooms { get; }

        public Flat(int NumberOfFlat, string Area, int NumberOfRooms)
        {
            numberOfFlat = NumberOfFlat;
            area = Area;
            numberOfFlat = NumberOfRooms;
        }
    }
}
