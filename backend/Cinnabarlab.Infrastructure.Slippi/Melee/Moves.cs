
using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Slippi.Melee
{
    public static class Moves
    {
        public static IList<Move> All => new List<Move>
        {
            new Move(1, "Miscellaneous", "misc"),
            new Move(2, "Jab", "jab"),
            new Move(3, "Jab", "jab"),
            new Move(4, "Jab", "jab"),
            new Move(5, "Rapid Jabs", "rapid-jabs"),
            new Move(6, "Dash Attack", "dash"),
            new Move(7, "Forward Tilt", "ftilt"),
            new Move(8, "Up Tilt", "utilt"),
            new Move(9, "Down Tilt", "dtilt"),
            new Move(10, "Forward Smash", "fsmash"),
            new Move(11, "Up Smash", "usmash"),
            new Move(12, "Down Smash", "dsmash"),
            new Move(13, "Neutral Air", "nair"),
            new Move(14, "Forward Air", "fair"),
            new Move(15, "Back Air", "bair"),
            new Move(16, "Up Air", "uair"),
            new Move(17, "Down Air", "dair"),
            new Move(18, "Neutral B", "neutral-b"),
            new Move(19, "Side B", "side-b"),
            new Move(20, "Up B", "up-b"),
            new Move(21, "Down B", "down-b"),
            new Move(50, "Getup Attack", "getup"),
            new Move(51, "Getup Attack (Slow)", "getup-slow"),
            new Move(52, "Grab Pummel", "pummel"),
            new Move(53, "Forward Throw", "fthrow"),
            new Move(54, "Back Throw", "bthrow"),
            new Move(55, "Up Throw", "uthrow"),
            new Move(56, "Down Throw", "dthrow"),
            new Move(61, "Edge Attack (Slow)", "edge-slow"),
            new Move(62, "Edge Attack", "edge"),
            new Move(-1, "Unknown Move", "unknown")
        };
    }
}
