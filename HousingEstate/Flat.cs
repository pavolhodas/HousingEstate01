using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        private List<int> NumberOfFlats = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        private readonly List<Person> peoples;

        public Flat()
        {
            peoples = new List<Person>
            {
                new Person("Pavol ", "Hodás ", 16),
                new Person("Miloš ", "Hodás ", 46),
                new Person("Katarína ", "Hodásová ", 40),
                new Person("Peter ", "Hodás ", 18)
            };
            
        }
        public void Update()
        {
            foreach(var people in peoples)
            {
                people.Update();
            }
        }
        public Person FindPersonBy(string name)
        {
            foreach (var people in peoples)
            {
                if (people.Name.ToLower() == name.ToLower())
                {
                    return people;
                }
            }
            return null;

        }
    }
}
