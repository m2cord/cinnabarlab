
using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface ICombo : IDuration, IDamage
    {
        int PlayerIndex { get; set; }
        IList<IMoveLanded> Moves { get; set; }
        bool DidKill { get; set; }
        int? LastHitBy { get; set; }
    }

    public class Combo : ICombo
    {
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
