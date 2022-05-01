using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IThrowActionCount
    {
        int Up { get; set; }
        int Down { get; set; }
        int Back { get; set; }
        int Forward { get; set; }
    }

    public class ThrowActionCount : IThrowActionCount
    {
        public int Up { get; set; }
        public int Down { get; set; }
        public int Back { get; set; }
        public int Forward { get; set; }
    }
}
