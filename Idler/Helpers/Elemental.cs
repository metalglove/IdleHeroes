using Idler.Helpers.Enumerations;
using System.Collections.Generic;
using System.Linq;

namespace Idler.Helpers
{
    public static class Elemental
    {
        private static Dictionary<EElement, EElement> ElementalWeaknessTable = new Dictionary<EElement, EElement>()
        {
            { EElement.Fire, EElement.Water },
            { EElement.Water, EElement.Thunder },
            { EElement.Thunder, EElement.Earth },
            { EElement.Earth, EElement.Wind },
            { EElement.Wind, EElement.Ice },
            { EElement.Ice, EElement.Fire },
        };

        public static EElement[] GetNeutralities(this EElement element)
        {
            return ElementalWeaknessTable.Keys.Except(new EElement[] { element.GetStrength(), element.GetWeakness() }).ToArray();
        }
        public static EElement GetWeakness(this EElement element)
        {
            return ElementalWeaknessTable[element];
        }
        public static EElement GetStrength(this EElement element)
        {
            return ElementalWeaknessTable.Single(set => set.Value == element).Key;
        }
    }
}
