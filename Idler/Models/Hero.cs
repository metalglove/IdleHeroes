using Idler.Helpers;
using Idler.Helpers.Interfaces;
using Idler.Models.Items;

namespace Idler.Models
{
    public class Hero : NotifyPropertyChanged, IDescribe, IHeroItemSlots
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public float Speed { get; private set; }
        public float Attack { get; private set; }
        public float Defense { get; private set; }
        public float Health { get; private set; }

        public Headwear Headwear { get; private set; }
        public Neckwear Neckwear { get; private set; }
        public Bodywear Bodywear { get; private set; }
        public Handwear Handwear { get; private set; }
        public Legwear Legwear { get; private set; }
        public Footwear Footwear { get; private set; }
        public Mainhand Mainhand { get; private set; }
        public Offhand Offhand { get; private set; }
        public Fingerwear Fingerwear { get; private set; }
    }
}
