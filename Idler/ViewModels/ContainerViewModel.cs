using Idler.Helpers;
using Idler.Helpers.Enumerations;
using Idler.Models;
using Idler.Models.Items;

namespace Idler.ViewModels
{
    public class ContainerViewModel : ViewModelBase
    {
        private ViewModelBase _activeViewModel;
        private GameViewModel _gameViewModel;
        private HeroesViewModel _heroesViewModel;
        private ItemsViewModel _itemsViewModel;

        public ViewModelBase ActiveViewModel
        {
            get => _activeViewModel;
            private set
            {
                _activeViewModel = value;
                RaisePropertyChanged();
            }
        }
        public GameViewModel GameViewModel
        {
            get => _gameViewModel;
            set
            {
                _gameViewModel = value;
                RaisePropertyChanged();
            }
        }
        public HeroesViewModel HeroesViewModel
        {
            get => _heroesViewModel;
            set
            {
                _heroesViewModel = value;
                RaisePropertyChanged();
            }
        }
        public ItemsViewModel ItemsViewModel
        {
            get => _itemsViewModel;
            set
            {
                _itemsViewModel = value;
                RaisePropertyChanged();
            }
        }

        public ContainerViewModel()
        {
            GameViewModel = new GameViewModel();

            HeroesViewModel = new HeroesViewModel();
            ItemsViewModel = new ItemsViewModel();
            ActiveViewModel = HeroesViewModel;

            Dagger dagger = new Dagger("Dagger of Fire", "A dagger that is made of the element Fire!", 15f, 1.05f, 100f, 1.1f, EElement.Fire, EHeroProperty.Attack);
            Crown crown = new Crown("Crown of Water", "A crown that is made of the element Water!", 150f, 1.2f, 1000f, 4f, EElement.Water, EHeroProperty.Health);
            Inventory.Items.Add(dagger);
            Inventory.Items.Add(crown);

            Hero Hero = new Hero("Fireman", "Man of the element Fire!", EElement.Fire);
            Hero.Mainhand.TryEquip(dagger);
            Hero.Headwear.TryEquip(crown);
        }
    }
}
