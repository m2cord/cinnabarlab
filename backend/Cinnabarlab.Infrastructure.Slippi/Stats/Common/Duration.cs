
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IDuration
    {
        long StartFrame { get; set; }
        long? EndFrame { get; set; }
    }

    public class Duration : IDuration
    {
        public long StartFrame { get; set; }
        public long? EndFrame { get; set; }
    }
}
