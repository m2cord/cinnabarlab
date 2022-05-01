
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public enum State
    {
        // Animation ID ranges
        DamageStart = 0x4b,
        DamageEnd = 0x5b,
        CaptureStart = 0xdf,
        CaptureEnd = 0xe8,
        GuardStart = 0xb2,
        GuardEnd = 0xb6,
        GroundedControlStart = 0xe,
        GroundedControlEnd = 0x18,
        SquatStart = 0x27,
        SquatEnd = 0x29,
        DownStart = 0xb7,
        DownEnd = 0xc6,
        TechStart = 0xc7,
        TechEnd = 0xcc,
        DyingStart = 0x0,
        DyingEnd = 0xa,
        ControlledJumpStart = 0x18,
        ControlledJumpEnd = 0x22,
        GroundAttackStart = 0x2c,
        GroundAttackEnd = 0x40,
        AerialAttackStart = 0x41,
        AerialAttackEnd = 0x4a,

        // Animation ID specific
        RollForward = 0xe9,
        RollBackward = 0xea,
        SpotDodge = 0xeb,
        AirDodge = 0xec,
        ActionWait = 0xe,
        ActionDash = 0x14,
        ActionKneeBend = 0x18,
        GuardOn = 0xb2,
        TechMissUp = 0xb7,
        TechMissDown = 0xbf,
        NeutralTech = 0xc7,
        ForwardTech = 0xc8,
        BackwardTech = 0xc9,
        WallTech = 0xca,
        MissedWallTech = 0xf7,
        Dash = 0x14,
        Turn = 0x12,
        LandingFallSpecial = 0x2b,
        JumpForward = 0x19,
        JumpBackward = 0x1a,
        FallForward = 0x1e,
        FallBackward = 0x1f,
        Grab = 0xd4,
        GrabWait = 0xd8,
        Pummel = 0xd9,
        CliffCatch = 0xfc,
        ThrowUp = 0xdd,
        ThrowForward = 0xdb,
        ThrowDown = 0xde,
        ThrowBack = 0xdc,
        DamageFall = 0x26,

        // Command Grabs
        BarrelWait = 0x125,
        CommandGrabRange1Start = 0x10a,
        CommandGrabRange1End = 0x130,

        CommandGrabRange2Start= 0x147,
        CommandGrabRange2End = 0x152,
    }

    public static class StateHelpers
    {
        public static bool IsInControl(int state)
        {
            var ground = state >= (int)State.GroundedControlStart && state <= (int)State.GroundedControlEnd;
            var squat = state >= (int)State.SquatStart && state <= (int)State.SquatEnd;
            var groundAttack = state >= (int)State.GroundAttackStart && state <= (int)State.GroundAttackEnd;
            var isGrab = state == (int)State.Grab;

            return ground || squat || groundAttack || isGrab;
        }

        public static bool IsTeching(int state)
            => state >= (int)State.TechStart && state <= (int)State.TechEnd;

        public static bool IsDown(int state)
            => state >= (int)State.DownStart && state <= (int)State.DownEnd;

        public static bool IsDamaged(int state)
            => state >= (int)State.DamageStart && state <= (int)State.DamageEnd || state == (int)State.DamageFall;

        public static bool IsGrabbed(int state)
            => state >= (int)State.CaptureStart && state <= (int)State.CaptureEnd;

        public static bool IsCommandGrabbed(int state)
        {
            var range1 = state >= (int)State.CommandGrabRange1Start && state <= (int)State.CommandGrabRange1End;
            var range2 = state >= (int)State.CommandGrabRange2Start && state <= (int)State.CommandGrabRange2End;
            var barrel = state == (int)State.BarrelWait;

            return range1 || range2 || barrel;
        }

        public static bool IsDead(int state)
            => state >= (int)State.DyingStart && state <= (int)State.DyingEnd;
    }
}
