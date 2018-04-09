using Idler.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idler.Models
{
    public class HeroModel : NotifyPropertyChanged
    {
        public ObservableCollection<Hero> Heroes { get; set; }
        public void LoadHeroes()
        {
            Heroes = new ObservableCollection<Hero>
            {

            };
        }
    }
}
