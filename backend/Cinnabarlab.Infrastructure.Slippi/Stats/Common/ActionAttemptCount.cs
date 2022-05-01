
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IActionAttemptCount
    {
        int Success { get; set; }
        int Fail { get; set; }
    }
    
    public class ActionAttemptCount : IActionAttemptCount
    {
        public int Success { get; set; }
        public int Fail { get; set; }
    }
}
