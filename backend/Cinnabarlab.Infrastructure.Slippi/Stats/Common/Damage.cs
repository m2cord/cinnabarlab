
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IDamage
    {
        float StartPercent { get; set; }
        float CurrentPercent { get; set; }
        float? EndPercent { get; set; }
    }

    public class Damage : IDamage
    {
        public float StartPercent { get; set; }
        public float CurrentPercent { get; set; }
        public float? EndPercent { get; set; }
    }
}
