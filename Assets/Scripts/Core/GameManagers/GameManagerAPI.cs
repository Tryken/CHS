using System;

using Core.Singletons;
using MoonSharp.Interpreter;

namespace Core.GameManagers
{
	[MoonSharpUserData]
	public class GameManagerAPI : Singleton<GameManagerAPI> 
	{
		public event EventHandler OnInitGame;
		public event EventHandler OnStartGame;
		public event EventHandler OnRunGame;
		public event EventHandler OnStopGame;
		public event EventHandler OnCloseGame;
		
		[MoonSharpHidden]
		public void RaiseOnInitGame()
		{
			OnInitGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpHidden]
		public void RaiseOnStartGame()
		{
			OnStartGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpHidden]
		public void RaiseOnRunGame()
		{
			OnRunGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpHidden]
		public void RaiseOnStopGame()
		{
			OnStopGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpHidden]
		public void RaiseOnCloseGame()
		{
			OnCloseGame?.Invoke(this, EventArgs.Empty);
		}

		[MoonSharpHidden]
		public void Clear()
		{
			Recreate();
		}
	}
}
