
using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IStats
    {
        bool GameComplete { get; set; }
        long LastFrame { get; set; }
        long PlayableFrameCount { get; set; }
        IList<IStock> Stocks { get; set; }
        IList<IConversion> Conversions { get; set; }
        IList<ICombo> Combos { get; set; }
        IList<IActionCounts> ActionCounts { get; set; }
        IList<IOverall> Overall { get; set; }
    }

    public class Stats : IStats
    {
        public bool GameComplete { get; set; }
        public long LastFrame { get; set; }
        public long PlayableFrameCount { get; set; }
        public IList<IStock> Stocks { get; set; }
        public IList<IConversion> Conversions { get; set; }
        public IList<ICombo> Combos { get; set; }
        public IList<IActionCounts> ActionCounts { get; set; }
        public IList<IOverall> Overall { get; set; }
    }
}
