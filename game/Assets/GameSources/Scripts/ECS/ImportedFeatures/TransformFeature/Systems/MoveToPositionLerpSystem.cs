#if EASY_JENNY
using System;
using Entitas;
using UnityEngine;

public class MoveToPositionLerpSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _objs;

	public MoveToPositionLerpSystem(GameContext game)
	{
		_objs = game.GetGroup(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.MoveToPosition, GameMatcher.TowardMoveSpeed,
			GameMatcher.Movable, GameMatcher.LerpMove));
	}

	public void Execute()
	{
		foreach (var item in _objs.GetEntities())
		{
			var speed = item.towardMoveSpeed.Value;
			var dir = Vector3.Lerp(new Vector3(item.position.value.x, item.position.value.y, item.position.value.z),
				item.moveToPosition.Value, speed * Time.deltaTime);
			
			item.ReplacePosition(dir);
			if (Vector3.Distance(item.position.value,item.moveToPosition.Value) < 1) 
				item.RemoveMoveToPosition();
		}
	}
}


#endif