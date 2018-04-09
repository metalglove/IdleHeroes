﻿using Idler.Helpers;
using Idler.Helpers.Enumerations;
using Idler.Models.Items;
using System.Collections.ObjectModel;

namespace Idler.Models
{
    public class Inventory : NotifyPropertyChanged
    {
        public static ObservableCollection<Item> Items { get; set; }

        public void LoadItems()
        {
            Items = new ObservableCollection<Item>
            {
                new Dagger("Dagger of Fire", "A dagger that is made of the element Fire!", 15f, 1.05f, 100f, 1.1f, EElement.Fire, EHeroProperty.Attack)
            };
        }
    }
}