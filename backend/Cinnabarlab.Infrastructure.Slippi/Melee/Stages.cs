﻿
using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Slippi.Melee
{
    public static class Stages
    {
        public static IList<Stage> All => new List<Stage>
        {
            new Stage(2, "Fountain of Dreams"),
            new Stage(3, "Pokémon Stadium"),
            new Stage(4, "Princess Peach's Castle"),
            new Stage(5, "Kongo Jungle"),
            new Stage(6, "Brinstar"),
            new Stage(7, "Corneria"),
            new Stage(8, "Yoshi's Story"),
            new Stage(9, "Onett"),
            new Stage(10, "Pokémon Stadium"),
            new Stage(11, "Rainbow Cruise"),
            new Stage(12, "Jungle Japes"),
            new Stage(13, "Great Bay"),
            new Stage(14, "Hyrule Temple"),
            new Stage(15, "Brinstar Depths"),
            new Stage(16, "Yoshi's Island"),
            new Stage(17, "Green Greens"),
            new Stage(18, "Fourside"),
            new Stage(19, "Mushroom Kingdom I"),
            new Stage(20, "Mushroom Kingdom II"),
            new Stage(22, "Venom"),
            new Stage(23, "Poké Floats"),
            new Stage(24, "Big Blue"),
            new Stage(25, "Icicle Mountain"),
            new Stage(26, "Icetop"),
            new Stage(27, "Flat Zone"),
            new Stage(28, "Dream Land N64"),
            new Stage(29, "Yoshi's Island N64"),
            new Stage(30, "Kongo Jungle N64"),
            new Stage(31, "Battlefield"),
            new Stage(32, "Final Destination"),
            new Stage(33, "Target test (Mario)"),
            new Stage(34, "Target test (Captain Falcon)"),
            new Stage(35, "Target test (Young Link)"),
            new Stage(36, "Target test (Donkey Kong)"),
            new Stage(37, "Target test (Dr. Mario)"),
            new Stage(38, "Target test (Falco)"),
            new Stage(39, "Target test (Fox)"),
            new Stage(40, "Target test (Ice Climbers)"),
            new Stage(41, "Target test (Kirby)"),
            new Stage(42, "Target test (Bowser)"),
            new Stage(43, "Target test (Link)"),
            new Stage(44, "Target test (Luigi)"),
            new Stage(45, "Target test (Marth)"),
            new Stage(46, "Target test (Mewtwo)"),
            new Stage(47, "Target test (Ness)"),
            new Stage(48, "Target test (Peach)"),
            new Stage(49, "Target test (Pichu)"),
            new Stage(50, "Target test (Pikachu)"),
            new Stage(51, "Target test (Jigglypuff)"),
            new Stage(52, "Target test (Samus)"),
            new Stage(53, "Target test (Sheik)"),
            new Stage(54, "Target test (Yoshi)"),
            new Stage(55, "Target test (Zelda)"),
            new Stage(56, "Target test (Mr. Game & Watch)"),
            new Stage(57, "Target test (Roy)"),
            new Stage(58, "Target test (Ganondorf)"),
            new Stage(84, "Home-Run Contest"),
            new Stage(-1, "Unknown Stage"),
        };
    }

    public enum StageEnum
    {
        FountainOfDreams = 2,
        PokemonStadium = 3,
        PeachsCastle = 4,
        KongoJungle = 5,
        Brinstar = 6,
        Corneria = 7,
        YoshisStory = 8,
        Onett = 9,
        MuteCity = 10,
        RainbowCruise = 11,
        JungleJapes = 12,
        GreatBay = 13,
        HyruleTemple = 14,
        BrinstarDepths = 15,
        YoshisIsland = 16,
        GreenGreens = 17,
        Fourside = 18,
        MushroomKingdom1 = 19,
        MushroomKingdom2 = 20,
        Venom = 22,
        PokeFloats = 23,
        BigBlue = 24,
        IcicleMountain = 25,
        Icetop = 26,
        FlatZone = 27,
        Dreamland = 28,
        YoshisIslandN64 = 29,
        KongoJungleN64 = 30,
        Battlefield = 31,
        FinalDestination = 32,
        TargetTestMario = 33,
        TargetTestCaptainFalcon = 34,
        TargetTestYoungLink = 35,
        TargetTestDonkeyKong = 36,
        TargetTestDrMario = 37,
        TargetTestFalco = 38,
        TargetTestFox = 39,
        TargetTestIceClimbers = 40,
        TargetTestKirby = 41,
        TargetTestBowser = 42,
        TargetTestLink = 43,
        TargetTestLuigi = 44,
        TargetTestMarth = 45,
        TargetTestMewtwo = 46,
        TargetTestNess = 47,
        TargetTestPeach = 48,
        TargetTestPichu = 49,
        TargetTestPikachu = 50,
        TargetTestJigglypuff = 51,
        TargetTestSamus = 52,
        TargetTestSheik = 53,
        TargetTestYoshi = 54,
        TargetTestZelda = 55,
        TargetTestGameNWatch = 56,
        TargetTestRoy = 57,
        TargetTestGanondorf = 58,
        HomeRunContest = 84,
    }
}