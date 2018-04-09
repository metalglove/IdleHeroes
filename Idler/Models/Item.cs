using Idler.Helpers;
using Idler.Helpers.Enumerations;
using Idler.Helpers.Interfaces;

namespace Idler.Models
{
    public abstract class Item : NotifyPropertyChanged, IDescribe, IUpgradable
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public int Level { get; private set; } = 1;
        public float Boost { get; private set; }
        public float BoostMultiplier { get; private set; }
        public float Cost { get; private set; }
        public float CostMultiplier { get; private set; }

        public EElement Element { get; private set; }
        public EHeroProperty HeroProperty { get; private set; }

        protected Item(string name, string description, float startingBoost, float boostMultiplier, float startingCost, float costMultiplier, EElement eElement, EHeroProperty eHeroProperty)
        {
            Name = name;
            Description = description;
            Boost = startingBoost;
            BoostMultiplier = boostMultiplier;
            Cost = startingCost;
            CostMultiplier = costMultiplier;
            Element = eElement;
            HeroProperty = eHeroProperty;
        }

        public void Upgrade()
        {

        }
    }
}
