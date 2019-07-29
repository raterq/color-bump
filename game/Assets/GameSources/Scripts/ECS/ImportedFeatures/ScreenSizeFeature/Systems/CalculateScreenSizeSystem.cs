#if EASY_JENNY
using Entitas;
using UnityEngine;

public class CalculateScreenSizeSystem : IInitializeSystem
{
	private readonly GameContext _game;

	public CalculateScreenSizeSystem(GameContext game)
	{
		_game = game;
	}

	public void Initialize()
	{
		float height = Camera.main.orthographicSize*2;
		float width = Camera.main.aspect * height;
		_game.screenEntity.AddScreenSize(new Vector2(width,height));
	}
}


#endif