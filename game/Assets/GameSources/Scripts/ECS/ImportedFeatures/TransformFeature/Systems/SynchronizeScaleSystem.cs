#if EASY_JENNY
using Entitas;

public class SynchronizeScaleSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _numbers;


	public SynchronizeScaleSystem(GameContext game)
	{
		_numbers = game.GetGroup(GameMatcher.AllOf(GameMatcher.TransformReplacer, GameMatcher.Scale));
	}

	public void Execute()
	{
		foreach (var number in _numbers.GetEntities())
		{
			number.transformReplacer.value.ReplaceScale(number.scale.x, number.scale.y, number.scale.z);
		}
	}
}


#endif