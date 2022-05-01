
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IStock : IDuration, IDamage
    {
        int PlayerIndex { get; set; }
        int Count { get; set; }
        int? DeathAnimation { get; set; }
    }

    public class Stock : IStock
    {
        public int PlayerIndex { get; set; }
        public int Count { get; set; }
        public int? DeathAnimation { get; set; }
        public long StartFrame { get; set; }
        public long? EndFrame { get; set; }
        public float StartPercent { get; set; }
        public float CurrentPercent { get; set; }
        public float? EndPercent { get; set; }
    }
}
