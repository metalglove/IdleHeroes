using Idler.Models;
using Idler.Models.Items;
using Idler.Models.Wear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idler.Helpers
{
    public static class Wearables
    {
        private static Dictionary<Type, List<Type>> WearableTable = new Dictionary<Type, List<Type>>
        {
            { typeof(Mainhand), new List<Type> { typeof(Dagger), typeof(Sword) } }
        };

        public static bool IsItemWearableFor(Wearable wearable, Item item)
        {
            return (WearableTable[wearable.GetType()]).Contains(item.GetType());
        }
    }
}
