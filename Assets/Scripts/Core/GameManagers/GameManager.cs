using System;
using Core.Singletons;
using UnityEngine;

namespace Core.GameManagers
{
    public class GameManager : SingletonMonoBehaviour<GameManager>
    {
        [field:SerializeField]
        public GameManagerState State { get; private set; }

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

        private static void OnSetCloseState()
        {
            GameManagerAPI.Instance.RaiseOnCloseGame();
            GameManagerAPI.Instance.Clear();
        }
    }
}
 