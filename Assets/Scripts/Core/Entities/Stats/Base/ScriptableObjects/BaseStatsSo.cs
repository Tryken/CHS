using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace Core.Entities.Stats.Base.ScriptableObjects
{
    [Serializable]
    [CreateAssetMenu(menuName = "Lua API/Entities/BaseStats", fileName = "New BaseStats")]
    public class BaseStatsSo : SerializedScriptableObject
    {
        [InlineEditor(InlineEditorModes.FullEditor, InlineEditorObjectFieldModes.CompletelyHidden)]
        public List<BaseStats> baseStats = new();

        [TitleGroup("Stats")] 
        [OdinSerialize]
        public int Agility { get; set; }
        [OdinSerialize]
        public int Intelligence { get; set; }
        [OdinSerialize]
        public int Strength { get; set; }
        
        public void CalculateValues(int level)
        {
            Agility = 0;
            Intelligence = 0;
            Strength = 0;
            
            foreach (var baseStat in baseStats)
            {
                switch (baseStat.BaseStatsType())
                {
                    case BaseStatsType.Agility:
                        Agility += baseStat.CalculateCurrentValue(level);
                        break;
                    case BaseStatsType.Intelligence:
                        Intelligence += baseStat.CalculateCurrentValue(level);
                        break;
                    case BaseStatsType.Strength:
                        Strength += baseStat.CalculateCurrentValue(level);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        [TitleGroup("Debug")]
        [ShowInInspector]
        public int DebugLevel { get; set; } = 1;
        
        [Button("Calculate Values")]
        private void DebugCalculateValues()
        {
            CalculateValues(DebugLevel);
        }
    }
}