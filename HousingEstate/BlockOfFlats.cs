using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class BlockOfFlats
    {
        private string blockOfFlatsName;
        private string nameOfStreet;

        public BlockOfFlats(string BlockOfFlatsName, string NameOfstreet)
        {
            blockOfFlatsName = BlockOfFlatsName;
            nameOfStreet = NameOfstreet;
        }
        public override string ToString()
        {
            return $"Panelák: {blockOfFlatsName}, Ulica: {nameOfStreet}";
        }
        
    }
}
