#if EASY_JENNY
using Entitas;

public class AddTappedComponentSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _handlers;

	public AddTappedComponentSystem(GameContext game)
	{
		_handlers = game.GetGroup(GameMatcher.AllOf(GameMatcher.InputTapHandler).NoneOf(GameMatcher.Tapped));
	}

	public void Execute()
	{
		foreach (var handler in _handlers.GetEntities())
		{
			if (handler.inputTapHandler.value.Tapped)
				handler.isTapped = true;
		}
	}
}


#endif