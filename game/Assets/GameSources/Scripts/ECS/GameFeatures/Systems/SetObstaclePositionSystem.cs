using Entitas;

public class SetObstaclePositionSystem : IInitializeSystem
{
    private readonly IGroup<GameEntity> _obstacles;

    public SetObstaclePositionSystem(GameContext game)
    {
        _obstacles = game.GetGroup(GameMatcher.AllOf(GameMatcher.Obstacle, GameMatcher.ObstacleBehaviour));
    }

    public void Initialize()
    {
        foreach (var obstacle in _obstacles.GetEntities())
            obstacle.obstacleBehaviour.value.SetPosition(obstacle.position.value);
    }
}