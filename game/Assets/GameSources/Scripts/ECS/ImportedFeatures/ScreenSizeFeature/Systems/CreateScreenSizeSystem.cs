#if EASY_JENNY
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CreateScreenSizeSystem : IInitializeSystem
{
	private readonly GameContext _game;

	public CreateScreenSizeSystem(GameContext game)
	{
		_game = game;
	}

	public void Initialize()
	{
		var screen = _game.CreateEntity();
		screen.isScreen = true;
	}
}


#endif