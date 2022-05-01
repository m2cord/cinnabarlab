
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IPlayerIndexed
    {
        int PlayerIndex { get; set; }
        int OpponentIndex { get; set; }
    }

    public class PlayerIndexed : IPlayerIndexed
    {
        public int PlayerIndex { get; set; }
        public int OpponentIndex { get; set; }
    }
}
