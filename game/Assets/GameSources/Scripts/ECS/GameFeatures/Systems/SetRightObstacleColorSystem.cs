using Entitas;
using UnityEngine;

public class SetRightObstacleColorSystem : IInitializeSystem
{
    private readonly IGroup<GameEntity> _obstacles;

    public SetRightObstacleColorSystem(GameContext game)
    {
        _obstacles = game.GetGroup(GameMatcher.AllOf(GameMatcher.Obstacle, GameMatcher.ObstacleBehaviour,
            GameMatcher.RightObstacle));
    }

    public void Initialize()
    {
        foreach (var obstacle in _obstacles.GetEntities())
            obstacle.obstacleBehaviour.value.SetColor(Color.green);
    }
}