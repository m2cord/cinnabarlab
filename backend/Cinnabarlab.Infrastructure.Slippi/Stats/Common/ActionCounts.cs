
using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IActionCounts
    {
        int PlayerIndex { get; set; }
        IList<IActionAttemptCount> WaveDashCount { get; set; }
        IList<IActionAttemptCount> WaveLandCount { get; set; }
        IList<IActionAttemptCount> AirDodgeCount { get; set; }
        IList<IActionAttemptCount> DashDanceCount { get; set; }
        IList<IActionAttemptCount> SpotDodgeCount { get; set; }
        IList<IActionAttemptCount> LedgeGrabCount { get; set; }
        IList<IActionAttemptCount> RollCount { get; set; }
        IList<IActionAttemptCount> LCancelCount { get; set; }
        IList<IActionAttemptCount> GrabCount { get; set; }
        IList<IThrowActionCount> ThrowCount { get; set; }
        IList<IGroundTechActionCount> GroundTechCount { get; set; }
        IList<IWallTechActionCount> WallTechCount { get; set; }
    }

    public class ActionCounts : IActionCounts
    {
        public int PlayerIndex { get; set; }
        public IList<IActionAttemptCount> WaveDashCount { get; set; }
        public IList<IActionAttemptCount> WaveLandCount { get; set; }
        public IList<IActionAttemptCount> AirDodgeCount { get; set; }
        public IList<IActionAttemptCount> DashDanceCount { get; set; }
        public IList<IActionAttemptCount> SpotDodgeCount { get; set; }
        public IList<IActionAttemptCount> LedgeGrabCount { get; set; }
        public IList<IActionAttemptCount> RollCount { get; set; }
        public IList<IActionAttemptCount> LCancelCount { get; set; }
        public IList<IActionAttemptCount> GrabCount { get; set; }
        public IList<IThrowActionCount> ThrowCount { get; set; }
        public IList<IGroundTechActionCount> GroundTechCount { get; set; }
        public IList<IWallTechActionCount> WallTechCount { get; set; }
    }
}
