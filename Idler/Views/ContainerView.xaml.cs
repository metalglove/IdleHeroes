using Idler.Helpers.Enumerations;
using Idler.Models;
using Idler.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Idler.Views
{
    public partial class ContainerView : Window
    {
        public ContainerView()
        {
            InitializeComponent();
            Hero Hero = new Hero("Fireman", "Man of the element Fire!", EElement.Fire);
            Hero.Mainhand.TryEquip(new Dagger("Dagger of Fire", "A dagger that is made of the element Fire!", 15f, 1.05f, 100f, 1.1f, EElement.Fire, EHeroProperty.Attack));
            Hero.Mainhand.TryEquip(new Crown("Crown of Water", "A crown that is made of the element Water!", 150f, 1.2f, 1000f, 4f, EElement.Water, EHeroProperty.Health));

        }
    }
}
