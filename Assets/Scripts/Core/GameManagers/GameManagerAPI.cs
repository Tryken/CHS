﻿using System;
using MoonSharp.Interpreter.Interop;
using Core.Singletons;

namespace Core.GameManagers
{
	public class GameManagerAPI : Singleton<GameManagerAPI> 
	{
		public event EventHandler OnInitGame;
		public event EventHandler OnStartGame;
		public event EventHandler OnRunGame;
		public event EventHandler OnStopGame;
		public event EventHandler OnCloseGame;
		
		[MoonSharpVisible(false)]
		public void RaiseOnInitGame()
		{
			OnInitGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpVisible(false)]
		public void RaiseOnStartGame()
		{
			OnStartGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpVisible(false)]
		public void RaiseOnRunGame()
		{
			OnRunGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpVisible(false)]
		public void RaiseOnStopGame()
		{
			OnStopGame?.Invoke(this, EventArgs.Empty);
		}
		
		[MoonSharpVisible(false)]
		public void RaiseOnCloseGame()
		{
			OnCloseGame?.Invoke(this, EventArgs.Empty);
		}

		[MoonSharpVisible(false)]
		public void Clear()
		{
			Recreate();
		}
	}
}