using System;

namespace Core.GameModes.Exceptions
{
    public class ScriptPathNotAllowed : Exception
    {
        public ScriptPathNotAllowed() {  }

        public ScriptPathNotAllowed(string name)
            : base($"Script Path Not Allowed: {name}")
        {
        }
    }
}