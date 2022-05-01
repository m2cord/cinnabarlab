
namespace Cinnabarlab.Infrastructure.Slippi.Melee
{
    public class Move
    {
        private int id;
        private string name;
        private string shortName;

        public Move(int id, string name, string shortName)
        {
            this.id = id;
            this.name = name;
            this.shortName = shortName;
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
    }
}
