using System;
using Sirenix.Serialization;
using UnityEngine;

namespace Core.Entities.Stats.Common.ScriptableObjects
{
    [Serializable]
    [CreateAssetMenu(menuName = "Lua API/Entities/Stats/Common/Mana", fileName = "New Mana")]
    public class ManaSo : CommonStats
    {
        [OdinSerialize] public int BaseValue { get; set; }
        [OdinSerialize] public int AdditionalBaseValue { get; set; }
        [OdinSerialize] public float BaseFactor { get; set; } = 1.0f;
        [OdinSerialize] public float PerIntelligence { get; set; } = 1.0f;
        [OdinSerialize] public int AdditionalValue { get; set; }
        [OdinSerialize] public float AdditionalFactor { get; set; } = 1.0f;
        [OdinSerialize] public int CurrentValue { get; set; }

        public override CommonStatsType CommonStatsType()
        {
            return Common.CommonStatsType.Intelligence;
        }

        public override void RecalculateValues(int value)
        {
            var currentBaseValue = (int) ((BaseValue + AdditionalBaseValue) * BaseFactor);
            var intelligenceValue = (int) (PerIntelligence * value);
            var currentAdditionalValue = (int) (AdditionalValue * AdditionalFactor);
            CurrentValue = currentBaseValue + intelligenceValue + currentAdditionalValue;
        }
    }
}