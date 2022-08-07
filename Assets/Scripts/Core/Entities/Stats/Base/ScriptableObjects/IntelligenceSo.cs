using System;
using Sirenix.Serialization;
using UnityEngine;

namespace Core.Entities.Stats.Base.ScriptableObjects
{
    [Serializable]
    [CreateAssetMenu(menuName = "Lua API/Entities/Stats/Base Stats/Intelligence", fileName = "New Intelligence")]
    public class IntelligenceSo : BaseStats
    {
        [OdinSerialize] public int BaseValue { get; set; }
        [OdinSerialize] public int AdditionalBaseValue { get; set; }
        [OdinSerialize] public float BaseFactor { get; set; } = 1.0f;
        [OdinSerialize] public float PerLevel { get; set; } = 1.0f;
        [OdinSerialize] public int AdditionalValue { get; set; }
        [OdinSerialize] public float AdditionalFactor { get; set; } = 1.0f;

        public override BaseStatsType BaseStatsType()
        {
            return Base.BaseStatsType.Intelligence;
        }

        public override int CalculateCurrentValue(int level)
        {
            var currentBaseValue = (int) ((BaseValue + AdditionalBaseValue) * BaseFactor);
            var levelValue = (int) (PerLevel * level);
            var currentAdditionalValue = (int) (AdditionalValue * AdditionalFactor);
            return currentBaseValue + levelValue + currentAdditionalValue;
        }
    }
}