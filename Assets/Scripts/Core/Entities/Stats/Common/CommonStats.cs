using System;
using Sirenix.OdinInspector;

namespace Core.Entities.Stats.Common
{
    [Serializable]
    public abstract class CommonStats : SerializedScriptableObject
    {
        public abstract CommonStatsType CommonStatsType();
        public abstract void RecalculateValues(int value);
    }
}