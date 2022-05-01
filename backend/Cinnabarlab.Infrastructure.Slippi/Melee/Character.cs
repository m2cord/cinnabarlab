using System.Collections.Generic;
using System.Linq;

namespace Cinnabarlab.Infrastructure.Slippi.Melee
{
    public class Character
    {
        private int id;
        private string name;
        private string shortName;
        
        internal Color[] colors;

        internal Character(int id, string name, string shortName, Color[] colors)
        {
            this.id = id;
            this.name = name;
            this.shortName = shortName;
            this.colors = colors;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string ShortName
        {
            get { return shortName; }
        }

        public IList<Color> Colors
        {
            get { return colors.ToList(); }
        }
    }
}
