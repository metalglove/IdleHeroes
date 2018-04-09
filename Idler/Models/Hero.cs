using Idler.Helpers;
using Idler.Helpers.Enumerations;
using Idler.Helpers.Interfaces;
using Idler.Models.Wear;
using System;

namespace Idler.Models
{
    public class Hero : NotifyPropertyChanged, IDescribe, IHeroStats, IHeroItemSlots, IUpgradable
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public float Speed { get; private set; } = 1;
        public float Attack { get; private set; } = 5;
        public float Defense { get; private set; } = 50;
        public float Health { get; private set; } = 100;

        public Headwear Headwear { get; private set; } = new Headwear();
        public Neckwear Neckwear { get; private set; } = new Neckwear();
        public Bodywear Bodywear { get; private set; } = new Bodywear();
        public Handwear Handwear { get; private set; } = new Handwear();
        public Legwear Legwear { get; private set; } = new Legwear();
        public Footwear Footwear { get; private set; } = new Footwear();
        public Mainhand Mainhand { get; private set; } = new Mainhand();
        public Offhand Offhand { get; private set; } = new Offhand();
        public Fingerwear Fingerwear { get; private set; } = new Fingerwear();

        public int Level { get; private set; } = 1;
        public float Boost { get; private set; } = 5f;
        public float BoostMultiplier { get; private set; } = 1.05f;
        public float Cost { get; private set; } = 15f;
        public float CostMultiplier { get; private set; } = 1.15f;

        public EElement Element { get; private set; }

        public Hero(string name, string description, EElement eElement)
        {
            Name = name;
            Description = description;
            Element = eElement;
        }

        public void Upgrade()
        {
            throw new ArgumentException();
        }
    }
}
