#if EASY_JENNY
using Entitas;

public class TriggerDestroyerSystem : ICleanupSystem
{
	private readonly IGroup<GameEntity> _objects;

	public TriggerDestroyerSystem(GameContext game)
	{
		_objects = game.GetGroup(GameMatcher.AllOf(GameMatcher.Destroyed, GameMatcher.Destroyer));
	}

	public void Cleanup()
	{
		foreach (var item in _objects.GetEntities())
		{
			item.destroyer.value.DestroyObject();
			item.RemoveDestroyer();
		}
	}
}


#endif