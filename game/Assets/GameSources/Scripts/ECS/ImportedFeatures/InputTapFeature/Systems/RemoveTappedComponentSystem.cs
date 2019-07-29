#if EASY_JENNY
using Entitas;

public class RemoveTappedComponentSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _objects;

	public RemoveTappedComponentSystem(GameContext game)
	{
		_objects = game.GetGroup(GameMatcher.AllOf(GameMatcher.InputTapHandler,GameMatcher.Tapped));
	}

	public void Execute()
	{
		foreach (var item in _objects.GetEntities())
		{
			if (!item.inputTapHandler.value.Tapped)
			{
				item.isTapped = false;
			}
		}
	}
}


#endif