using System;
using Core.Managers.GameModeManagers;
using Core.Singletons;
using UnityEditor;
using UnityEngine;

namespace Core.Managers.GameManagers
{
    [Serializable]
    public class GameManager : SingletonMonoBehaviour<GameManager>
    {
        [field:SerializeField]
        public GameManagerState State { get; private set; }

        private void Awake()
        {
#if  UNITY_EDITOR
            AssetDatabase.DeleteAsset("Assets/_tmp");
            AssetDatabase.CreateFolder("Assets", "_tmp");   
#endif
        }
        
        public void SetState(GameManagerState state)
        {
            State = state;
            switch (state)
            {
                case GameManagerState.Init:
                    GameManagerAPI.Instance.RaiseOnInitGame();
                    break;
                case GameManagerState.Start:
                    GameManagerAPI.Instance.RaiseOnStartGame();
                    break;
                case GameManagerState.Run:
                    GameManagerAPI.Instance.RaiseOnRunGame();
                    break;
                case GameManagerState.Stop:
                    GameManagerAPI.Instance.RaiseOnStopGame();
                    break;
                case GameManagerState.Close:
                    OnSetCloseState();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }
        
        public void Clear()
        {
            GameManagerAPI.Instance.Clear();
#if UNITY_EDITOR
            AssetDatabase.DeleteAsset("Assets/_tmp");       
#endif
        }

        private void OnSetCloseState()
        {
            GameManagerAPI.Instance.RaiseOnCloseGame();
            GameModeManager.Instance.ClearGameManager();
        }
    }
}
 