using Idler.Models;
using Idler.Models.Items;
using Idler.Models.Wear;
using System;
using System.Collections.Generic;

namespace Idler.Helpers
{
    public static class Wearables
    {
        private static Dictionary<Type, List<Type>> WearableTable = new Dictionary<Type, List<Type>>
        {
            { typeof(Mainhand), new List<Type> { typeof(Dagger), typeof(Sword) } },
            { typeof(Offhand), new List<Type> { typeof(Dagger), typeof(Sword) } },
            { typeof(Headwear), new List<Type> { typeof(Crown) } },
            { typeof(Neckwear), new List<Type> { } },
            { typeof(Bodywear), new List<Type> { } },
            { typeof(Handwear), new List<Type> { } },
            { typeof(Legwear), new List<Type> { } },
            { typeof(Footwear), new List<Type> { } },
            { typeof(Fingerwear), new List<Type> { } }
        };

        public static bool IsItemWearableFor(Wearable wearable, Item item)
        {
            return (WearableTable[wearable.GetType()]).Contains(item.GetType());
        }
    }
}
