

namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface ITimerSettings
    {
        int PunishResetFrames { get; set; }
        int RecoveryResetFrames { get; set; }
        int ComboStringResetFrames { get; set; }
    }

    public class TimerSettings : ITimerSettings
    {
        public int PunishResetFrames { get; set; } = 45;
        public int RecoveryResetFrames { get; set; } = 45;
        public int ComboStringResetFrames { get; set; } = 45;
    }
}
