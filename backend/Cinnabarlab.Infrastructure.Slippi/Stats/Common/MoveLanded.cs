
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IMoveLanded
    {
        int PlayerIndex { get; set; }
        int Frame { get; set; }
        int MoveId { get; set; }
        int HitCount { get; set; }
        float Damage { get; set; }
    }

    public class MoveLanded : IMoveLanded
    {
        public int PlayerIndex { get; set; }
        public int Frame { get; set; }
        public int MoveId { get; set; }
        public int HitCount { get; set; }
        public float Damage { get; set; }
    }
}
