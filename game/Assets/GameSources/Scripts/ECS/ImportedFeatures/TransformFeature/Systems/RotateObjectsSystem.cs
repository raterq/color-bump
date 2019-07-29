#if EASY_JENNY
using Entitas;

public class RotateObjectsSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _objects;

	public RotateObjectsSystem(GameContext game)
	{
		_objects = game.GetGroup(GameMatcher.AllOf(GameMatcher.Rotate, GameMatcher.Position,
			GameMatcher.TransformReplacer));
	}

	public void Execute()
	{
		foreach (var item in _objects.GetEntities())
		{
			item.transformReplacer.value.Rotate(item.rotate.axis,item.rotate.angle);
		}
	}
}

#endif