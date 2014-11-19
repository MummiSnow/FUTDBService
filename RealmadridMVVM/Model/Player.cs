using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmadridMVVM
{
    class Player
    {
        public string Name { get; set; }
        public int KitNumber { get; set; }
        public int Age { get; set; }

        public string Position { get; set; }

        public Player()
        {
            
        }

        public Player(string name, int kitNumber, int age, string position)
        {
            Name = name;
            KitNumber = kitNumber;
            Age = age;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, KitNumber: {1}, Age: {2}, Position: {3}", Name, KitNumber, Age, Position);
        }
    }
}
