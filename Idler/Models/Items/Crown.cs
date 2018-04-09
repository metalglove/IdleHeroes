using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idler.Helpers.Enumerations;

namespace Idler.Models.Items
{
    public class Crown : Item
    {
        public Crown(string name, string description, float startingBoost, float boostMultiplier, float startingCost, float costMultiplier, EElement eElement, EHeroProperty eHeroProperty) : base(name, description, startingBoost, boostMultiplier, startingCost, costMultiplier, eElement, eHeroProperty)
        {

        }
    }
}
