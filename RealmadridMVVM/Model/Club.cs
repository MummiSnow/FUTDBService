using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmadridMVVM
{
    class Club
    {
        public string ClubName { get; set; }
        public string Country { get; set; }
        public string Division { get; set; }

        public int Founded { get; set; }

        public Club(string clubName, string country, string division, int founded)
        {
            ClubName = clubName;
            Country = country;
            Division = division;
            Founded = founded;
        }

        public Club()
        {
            
        }

        public override string ToString()
        {
            return string.Format("Country: {0}, ClubName: {1}, Division: {2}, Founded: {3}", Country, ClubName, Division, Founded);
        }
    }
}
