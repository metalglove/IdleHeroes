﻿using Idler.Models;
using Idler.Models.Wear;
using System;

namespace Idler.Helpers.Interfaces
{
    public interface IHeroItemSlots
    {
        Headwear Headwear { get; }
        Neckwear Neckwear { get; }
        Bodywear Bodywear { get; }
        Handwear Handwear { get; }
        Legwear Legwear { get; }
        Footwear Footwear { get; }
        Mainhand Mainhand { get; }
        Offhand Offhand { get; }
        Fingerwear Fingerwear { get; }
    }
}
