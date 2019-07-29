#if EASY_JENNY
using Entitas;
using UnityEngine;

public class SinusoidalMoveSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _entities;

	public SinusoidalMoveSystem(GameContext game)
	{
		_entities = game.GetGroup(GameMatcher.AllOf(GameMatcher.SinusoidalMove, GameMatcher.Position,
			GameMatcher.Time, GameMatcher.Amplitude, GameMatcher.SinusoidalAxis));
	}

	public void Execute()
	{
		foreach (var entity in _entities.GetEntities())
		{
			DecreaseTime(entity); 

			var position = entity.position.value;
			var targetAxis = entity.sinusoidalAxis.Value;

			var newPosition = Move(targetAxis ,position,
				entity.sinusoidalMove.speed,
				entity.amplitude.value, entity.time.value);

			entity.ReplacePosition(newPosition);
		}
	}

	private static void DecreaseTime (GameEntity entity)
	{
		entity.time.value += Time.deltaTime;
	}

	private static Vector3 Move(Vector3 axis, Vector3 position, float sinusoidalSpeed, float amplitude, float time)
	{
		position += axis * amplitude * Mathf.Sin(time * sinusoidalSpeed);
		return position;
	}
}


#endif