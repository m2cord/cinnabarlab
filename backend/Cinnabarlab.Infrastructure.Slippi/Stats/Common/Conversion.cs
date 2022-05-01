
using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IConversion : ICombo
    {
        string OpeningType { get; set; }
    }

    public class Conversion : IConversion
    {
        public string OpeningType { get; set; }
        public int PlayerIndex { get; set; }
        public IList<IMoveLanded> Moves { get; set; }
        public bool DidKill { get; set; }
        public int? LastHitBy { get; set; }
        public long StartFrame { get; set; }
        public long? EndFrame { get; set; }
        public float StartPercent { get; set; }
        public float CurrentPercent { get; set; }
        public float? EndPercent { get; set; }
    }
}
