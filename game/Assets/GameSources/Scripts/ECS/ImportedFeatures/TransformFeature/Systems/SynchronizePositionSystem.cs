#if EASY_JENNY
using Entitas;

public class SynchronizePositionSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _numbers;


	public SynchronizePositionSystem(GameContext game)
	{
		_numbers = game.GetGroup(GameMatcher.AllOf(GameMatcher.TransformReplacer, GameMatcher.Position));
	}

	public void Execute()
	{
		foreach (var number in _numbers.GetEntities())
		{
			number.transformReplacer.value.ReplacePosition(number.position.value.x,
				number.position.value.y, number.position.value.z);
		}
	}
}


#endif