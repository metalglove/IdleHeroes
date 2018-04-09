using Idler.Helpers;
using System.Collections.ObjectModel;

namespace Idler.Models
{
    public class Inventory : NotifyPropertyChanged
    {
        public static ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
    }
}
