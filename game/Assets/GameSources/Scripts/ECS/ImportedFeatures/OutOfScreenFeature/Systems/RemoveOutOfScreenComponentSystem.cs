#if EASY_JENNY
using Entitas;

public class RemoveOutOfScreenComponentSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _objects;

	public RemoveOutOfScreenComponentSystem(GameContext game)
	{
		_objects = game.GetGroup(GameMatcher.AllOf(GameMatcher.CheckInScreen,GameMatcher.OutOfScreen));
	}

	public void Execute()
	{
		foreach (var item in _objects.GetEntities())
		{
			if (item.checkInScreen.value.InScreen)
			{
				item.isOutOfScreen = false;
			}
		}
	}
}

#endif