using Idler.Helpers;
using Idler.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idler.Models.Wear
{
    public abstract class Wearable : IWearable
    {
        public Item Item { get; private set; }

        public bool TryEquip(Item item)
        {
            if (Wearables.IsItemWearableFor(this, item) && Item != null)
            {
                Inventory.Items.Single(itemInInventory => itemInInventory == item).IsEquiped = true;
                Item = item;
                return true;
            }
            else
            {
                //TODO: Notify error
                return false;
            }
        }

        public void ReplaceWith(Item item)
        {
            Unequip();
            TryEquip(item);
        }

        public void Unequip()
        {
            Inventory.Items.Single(itemInInventory => itemInInventory == Item).IsEquiped = false;
            Item = null;
        }
    }
}
