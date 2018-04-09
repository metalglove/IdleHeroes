namespace Idler.Helpers.Interfaces
{
    public interface IUpgradable
    {
        int Level { get; }
        float Boost { get; }
        float BoostMultiplier { get; }
        float Cost { get; }
        float CostMultiplier { get; }

        void Upgrade();
    }
}
