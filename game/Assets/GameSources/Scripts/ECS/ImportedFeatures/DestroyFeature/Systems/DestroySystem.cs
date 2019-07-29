#if EASY_JENNY
using Entitas;

public class DestroySystem : ICleanupSystem
{
	private readonly IGroup<GameEntity> _objects;

	public DestroySystem(GameContext game)
	{
		_objects = game.GetGroup(GameMatcher.AllOf(GameMatcher.Destroyed).NoneOf(GameMatcher.Destroyer));
	}

	public void Cleanup()
	{
		foreach (var item in _objects.GetEntities())
		{
			item.Destroy();
		}
	}
}


#endif