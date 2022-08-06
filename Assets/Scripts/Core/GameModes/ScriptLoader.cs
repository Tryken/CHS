using System.IO;
using Core.GameModes.Exceptions;
using Core.Managers.GameModeManagers;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using Unity.VisualScripting;
using UnityEngine;

namespace Core.GameModes
{
    public class ScriptLoader : ScriptLoaderBase
    {
        public override bool ScriptFileExists(string name)
        {
            CheckPath(name);
            var gameMode = GameModeManager.Instance.CurrentGameMode;
            return File.Exists($"{GameModeManager.BASE_GAME_MODE_PATH}/{gameMode}/{name}");
        }

        public override object LoadFile(string file, Table globalContext)
        {
            CheckPath(file);
            var gameMode = GameModeManager.Instance.CurrentGameMode;
            return File.ReadAllText($"{GameModeManager.BASE_GAME_MODE_PATH}/{gameMode}/{file}");
        }

        private static void CheckPath(string path)
        {
            if (path.Contains(".."))
            {
                throw new ScriptPathNotAllowed("Jumping back from folders with .. is not allowed for security reasons");
            }
        }
    }
}