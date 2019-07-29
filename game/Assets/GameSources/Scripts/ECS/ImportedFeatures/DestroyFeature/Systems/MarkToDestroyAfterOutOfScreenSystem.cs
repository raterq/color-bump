#if EASY_JENNY
using Entitas;

public class MarkToDestroyAfterOutOfScreenSystem : ICleanupSystem
{
	private readonly IGroup<GameEntity> _objects;

	public MarkToDestroyAfterOutOfScreenSystem(GameContext game)
	{
		_objects = game.GetGroup(GameMatcher.AllOf(GameMatcher.DestroyAfterOutOfScreen,GameMatcher.OutOfScreen));
	}

	public void Cleanup()
	{
		foreach (var item in _objects.GetEntities())
		{
			item.isDestroyed = true;
		}
	}
}


#endif