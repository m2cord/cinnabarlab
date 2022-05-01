
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IWallTechActionCount
    {
        int Jump { get; set; }
        int NoJump { get; set; }
        int Fail { get; set; }
    }

    class WallTechActionCount : IWallTechActionCount
    {
        public int Jump { get; set; }
        public int NoJump { get; set; }
        public int Fail { get; set; }
    }
}
