
namespace Cinnabarlab.Infrastructure.Slippi.Melee
{
    public class Stage
    {
        private int id;
        private string name;

        public Stage(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
