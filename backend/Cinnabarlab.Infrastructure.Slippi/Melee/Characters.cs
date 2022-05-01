
using System.Collections.Generic;
using System.Linq;

namespace Cinnabarlab.Infrastructure.Slippi.Melee
{
    public static class Characters
    {
        public static IList<Character> All => new List<Character>
        {
            new Character(0, "Captain Falcon", "Falcon", new Color[] { Color.Neutral, Color.Black, Color.Red, Color.White, Color.Green, Color.Blue }),
            new Character(1, "Donkey Kong", "DK", new Color[] { Color.Neutral, Color.Black, Color.Red, Color.Blue, Color.Green }),
            new Character(2, "Fox", "Fox", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green }),
            new Character(3, "Mr. Game & Watch", "G&W", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green }),
            new Character(4, "Kirby", "Kirby", new Color[] { Color.Neutral, Color.Yellow, Color.Blue, Color.Red, Color.Green, Color.White }),
            new Character(5, "Bowser", "Bowser", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Black }),
            new Character(6, "Link", "Link", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Black, Color.White }),
            new Character(7, "Luigi", "Luigi", new Color[] { Color.Neutral, Color.White, Color.Blue, Color.Red }),
            new Character(8, "Mario", "Mario", new Color[] { Color.Neutral, Color.Yellow, Color.Black, Color.Blue, Color.Green }),
            new Character(9, "Marth", "Marth", new Color[] { Color.Neutral, Color.Red, Color.Green, Color.Black, Color.White }),
            new Character(10, "Mewtwo", "M2", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green }),
            new Character(11, "Ness", "Ness", new Color[] { Color.Neutral, Color.Yellow, Color.Blue, Color.Green }),
            new Character(12, "Peach", "Peach", new Color[] { Color.Neutral, Color.Yellow, Color.White, Color.Blue, Color.Green }),
            new Character(13, "Pikachu", "Pika", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green }),
            new Character(14, "Ice Climbers", "ICs", new Color[] { Color.Neutral, Color.Green, Color.Orange, Color.Red }),
            new Character(15, "Jigglypuff", "Puff", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green, Color.Yellow }),
            new Character(16, "Samus", "Samus", new Color[] { Color.Neutral, Color.Pink, Color.Black, Color.Green, Color.Purple }),
            new Character(17, "Yoshi", "Yoshi", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Yellow, Color.Pink, Color.Cyan }),
            new Character(18, "Zelda", "Zelda", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green, Color.White }),
            new Character(19, "Sheik", "Sheik", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green, Color.White }),
            new Character(20, "Falco", "Falco", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green }),
            new Character(21, "Young Link", "YLink", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.White, Color.Black }),
            new Character(22, "Dr.Mario", "Doc", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green, Color.Black }),
            new Character(23, "Roy", "Roy", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green, Color.Yellow }),
            new Character(24, "Pichu", "Pichu", new Color[] { Color.Neutral, Color.Black, Color.Red, Color.White, Color.Green, Color.Blue }),
            new Character(25, "Ganondorf", "Ganon", new Color[] { Color.Neutral, Color.Red, Color.Blue, Color.Green, Color.Purple }),
            new Character(26, "Master Hand", "MH", new Color[] { Color.Neutral }),
            new Character(27, "Wireframe (Male)", "WFM", new Color[] { Color.Neutral }),
            new Character(28, "Wireframe (Female)", "WFF", new Color[] { Color.Neutral }),
            new Character(29, "Gigabowser", "GBowser", new Color[] { Color.Neutral }),
            new Character(30, "Crazy Hand", "CH", new Color[] { Color.Neutral }),
            new Character(31, "Sandbag", "Sandbag", new Color[] { Color.Neutral }),
            new Character(32, "Popo", "Popo", new Color[] { Color.Neutral }),
            new Character(-1, "Unknown Character", "Unknown", new Color[] { Color.Neutral })
        };

        public static IList<Character> legal => All.Where(c => c.Id <= 25 && c.Id >= 0).ToList();
    }

    public enum CharacterEnum
    {
        CaptainFalcon = 0,
        DonkeyKong = 1,
        Fox = 2,
        GameNWatch = 3,
        Kirby = 4,
        Bowser = 5,
        Link = 6,
        Luigi = 7,
        Mario = 8,
        Marth = 9,
        Mewtwo = 10,
        Ness = 11,
        Peach = 12,
        Pikachu = 13,
        IceClimbers = 14,
        JigglyPuff = 15,
        Samus = 16,
        Yoshi = 17,
        Zelda = 18,
        Sheik = 19,
        Falco = 20,
        YoungLink = 21,
        DrMario = 22,
        Roy = 23,
        Pichu = 24,
        Ganondorf = 25,
        MasterHand = 26,
        WireFrameMale = 27,
        WireFrameFemale = 28,
        GigaBowser = 29,
        CrazyHand = 30,
        Sandbag = 31,
        Popo = 32,
    }
}
