
namespace Cinnabarlab.Infrastructure.Slippi.Stats.Common
{
    public interface IOverall
    {
        int PlayerIndex { get; set; }
        IInputCount InputCount { get; set; }
        int ConversionCount { get; set; }
        float TotalDamage { get; set; }
        int KillCount { get; set; }
        IRatio SuccessfulConversions { get; set; }
        IRatio InputsPerMinute { get; set; }
        IRatio DigitalInputsPerMinute { get; set; }
        IRatio OpeningsPerKill { get; set; }
        IRatio DamagePerOpening { get; set; }
        IRatio NeutralWinRatio { get; set; }
        IRatio CounterHitRatio { get; set; }
        IRatio BeneficialTradeRatio { get; set; }
    }

    public class Overall : IOverall
    {
        public int PlayerIndex { get; set; }
        public IInputCount InputCount { get; set; }
        public int ConversionCount { get; set; }
        public float TotalDamage { get; set; }
        public int KillCount { get; set; }
        public IRatio SuccessfulConversions { get; set; }
        public IRatio InputsPerMinute { get; set; }
        public IRatio DigitalInputsPerMinute { get; set; }
        public IRatio OpeningsPerKill { get; set; }
        public IRatio DamagePerOpening { get; set; }
        public IRatio NeutralWinRatio { get; set; }
        public IRatio CounterHitRatio { get; set; }
        public IRatio BeneficialTradeRatio { get; set; }
    }
}
