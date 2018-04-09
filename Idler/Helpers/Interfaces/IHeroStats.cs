using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idler.Helpers.Interfaces
{
    public interface IHeroStats
    {
        float Attack { get; }
        float Defense { get; }
        float Speed { get; }
        float Health { get; }
    }
}
