
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IGroundTechActionCount
    {
        int Away { get; set; }
        int In { get; set; }
        int Neutral { get; set; }
        int Fail { get; set; }
    }

    class GroundTechActionCount : IGroundTechActionCount
    {
        public int Away { get; set; }
        public int In { get; set; }
        public int Neutral { get; set; }
        public int Fail { get; set; }
    }
}
