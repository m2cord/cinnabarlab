
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IInputCount
    {
        int Buttons { get; set; }
        int Triggers { get; set; }
        int Joystick { get; set; }
        int CStick { get; set; }
        int Total { get; set; }
    }

    class InputCount : IInputCount
    {
        public int Buttons { get; set; }
        public int Triggers { get; set; }
        public int Joystick { get; set; }
        public int CStick { get; set; }
        public int Total { get; set; }
    }
}
