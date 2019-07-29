using Entitas;
using UnityEngine;

public class SetNotRightObstacleColorSystem : IInitializeSystem
{
    private readonly IGroup<GameEntity> _obstacles;

    public SetNotRightObstacleColorSystem(GameContext game)
    {
        _obstacles = game.GetGroup(GameMatcher.AllOf(GameMatcher.Obstacle, GameMatcher.ObstacleBehaviour)
            .NoneOf(GameMatcher.RightObstacle));
    }

    public void Initialize()
    {
        foreach (var obstacle in _obstacles.GetEntities())
            obstacle.obstacleBehaviour.value.SetColor(Color.red);
    }
}