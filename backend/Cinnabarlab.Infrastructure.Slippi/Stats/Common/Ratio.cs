
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IRatio
    {
        public int Count { get; set; }
        public int Total { get; set; }
        public int? Ratio { get; set; }
    }

    public class Ratio : IRatio
    {
        public int Count { get; set; }
        public int Total { get; set; }
        int? IRatio.Ratio { get; set; }
    }
}
