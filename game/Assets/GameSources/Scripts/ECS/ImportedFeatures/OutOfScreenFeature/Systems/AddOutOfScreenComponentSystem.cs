#if EASY_JENNY
using Entitas;

public class AddOutOfScreenComponentSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _objects;

	public AddOutOfScreenComponentSystem(GameContext game) => _objects =
		game.GetGroup(GameMatcher.AllOf(GameMatcher.CheckInScreen).NoneOf(GameMatcher.OutOfScreen));

	public void Execute()
	{
		foreach (var item in _objects.GetEntities())
			if (!item.checkInScreen.value.InScreen)
				item.isOutOfScreen = true;
	}
}

#endif