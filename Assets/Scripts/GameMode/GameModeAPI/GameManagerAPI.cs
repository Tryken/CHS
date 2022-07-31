using System;
using MoonSharp.Interpreter.Interop;

public class GameManagerAPI
{
	[MoonSharpVisible(false)]
	public static GameManagerAPI Instance { get; private set; }

	public event EventHandler OnInitGame;

	[MoonSharpVisible(false)]
	public GameManagerAPI()
    {
		if (Instance == null)
			Instance = this;
    }

	[MoonSharpVisible(false)]
	public void RaiseOnInitGame()
	{
		if (OnInitGame != null)
			OnInitGame(this, EventArgs.Empty);
	}
}
