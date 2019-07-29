#if EASY_JENNY
using Entitas;
using UnityEngine;

public class DirectionMoveSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _movableEntities;

    public DirectionMoveSystem(GameContext game)
    {
        _movableEntities = game.GetGroup(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.DirectionMoveSpeed,
            GameMatcher.Movable, GameMatcher.DirectionMove, GameMatcher.DirectionAxis));
    }

    public void Execute()
    {
        foreach (var item in _movableEntities.GetEntities())
            item.position.value += item.directionAxis.Value * item.directionMoveSpeed.Value * Time.deltaTime;
    }
}

#endif