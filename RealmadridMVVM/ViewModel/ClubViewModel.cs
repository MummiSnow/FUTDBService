using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmadridMVVM.ViewModel
{
    class ClubViewModel
    {
        public ObservableCollection<Club> Clubs { get; set; }
        public ObservableCollection<Player> Players { get; set; }

        public ClubViewModel()
        {
            Clubs = new ObservableCollection<Club>() {new Club("Real Madrid", "Spanish", "Primera Division",1980),
                new Club("Liverpool", "English", "Premier League",1880)};
           
            
            
        }


    }
}
