using System;
using Sirenix.Serialization;
using UnityEngine;

namespace Core.Entities.Stats.Common.ScriptableObjects
{
    [Serializable]
    [CreateAssetMenu(menuName = "Lua API/Entities/Stats/Common/Health", fileName = "New Health")]
    public class HealthSo : CommonStats
    {
        [OdinSerialize] public int BaseValue { get; set; }
        [OdinSerialize] public int AdditionalBaseValue { get; set; }
        [OdinSerialize] public float BaseFactor { get; set; } = 1.0f;
        [OdinSerialize] public float PerStrength { get; set; } = 1.0f;
        [OdinSerialize] public int AdditionalValue { get; set; }
        [OdinSerialize] public float AdditionalFactor { get; set; } = 1.0f;
        [OdinSerialize] public int CurrentValue { get; set; }

        public override CommonStatsType CommonStatsType()
        {
            return Common.CommonStatsType.Strength;
        }

        public override void RecalculateValues(int value)
        {
            var currentBaseValue = (int) ((BaseValue + AdditionalBaseValue) * BaseFactor);
            var strengthValue = (int) (PerStrength * value);
            var currentAdditionalValue = (int) (AdditionalValue * AdditionalFactor);
            CurrentValue = currentBaseValue + strengthValue + currentAdditionalValue;
        }
    }
}