using Idler.Helpers.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idler.Models.Items
{
    public class Fingerwear : Item
    {
        public Fingerwear(string name, string description, float startingBoost, float boostMultiplier, float startingCost, float costMultiplier, EElement eElement, EHeroProperty eHeroProperty)
           : base(name, description, startingBoost, boostMultiplier, startingCost, costMultiplier, eElement, eHeroProperty)
        {

        }
    }
}
