using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;

namespace Core.GameModes
{
    public class ScriptLoader : ScriptLoaderBase
    {
        public override bool ScriptFileExists(string name)
        {
            throw new System.NotImplementedException();
        }

        public override object LoadFile(string file, Table globalContext)
        {
            throw new System.NotImplementedException();
        }
    }
}