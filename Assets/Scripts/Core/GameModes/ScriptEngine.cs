using System;
using System.IO;
using System.Net;
using Core.GameManagers;
using Core.ItemsManagers;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Core.GameModes
{
    public class ScriptEngine
    {
        private Script script;
        
        public ScriptEngine(Script script)
        {
            this.script = script;
        }
        
        public static ScriptEngine InitScriptEngine(string gameMode)
        {
            var script = new Script(CoreModules.GlobalConsts | CoreModules.LoadMethods | CoreModules.Basic)
            {
                Options =
                {
                    DebugPrint = Debug.Log,
                    ScriptLoader = new ScriptLoader() 
                    { 
                        ModulePaths = new[] { "?.lua" } 
                    }
                }
            };
            
            RegisterGlobals(script);
            
            try 
            {
                script.DoString("require 'main'");
            }
            catch (ScriptRuntimeException ex)
            {
                Debug.LogErrorFormat("GameMode {0} RuntimeException {1}", gameMode, ex.DecoratedMessage);
            }
            catch (SyntaxErrorException ex)
            {
                Debug.LogErrorFormat("GameMode {0} SyntaxErrorException {1}", gameMode, ex.DecoratedMessage);
            }

            return new ScriptEngine(script);
        }

        private static void RegisterGlobals(Script script)
        {
            UserData.RegisterType<EventArgs>();
            UserData.RegisterType<GameManagerAPI>();
            script.Globals["GameManagerAPI"] = GameManagerAPI.Instance;
            UserData.RegisterType<ItemManagerAPI>();
            script.Globals["ItemManagerAPI"] = ItemManagerAPI.Instance;
        }
    }
}