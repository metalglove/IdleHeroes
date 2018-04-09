using Idler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idler.Helpers.Interfaces
{
    public interface IWearable
    {
        void ReplaceWith(Item item);
        bool TryEquip(Item item);
        void Unequip();
        Item Item { get; }
    }
}
