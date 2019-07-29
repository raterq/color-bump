#if EASY_JENNY
using Entitas;
using UnityEngine;

public class MoveToPositionTowardsSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _objs;

	public MoveToPositionTowardsSystem(GameContext game)
	{
		_objs = game.GetGroup(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.MoveToPosition, GameMatcher.TowardMoveSpeed,
			GameMatcher.Movable, GameMatcher.TowardsMove));
	}

	public void Execute()
	{
		foreach (var item in _objs.GetEntities())
		{
			var dir = Vector3.MoveTowards(new Vector3(item.position.value.x, item.position.value.y, item.position.value.z),
				item.moveToPosition.Value, item.towardMoveSpeed.Value * Time.deltaTime);
			
			item.ReplacePosition(dir);
			if (Vector3.Distance(item.position.value, item.moveToPosition.Value) < 0.01f) 
				item.RemoveMoveToPosition();
		}
	}
}

#endif