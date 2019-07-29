using Entitas;
using UnityEngine;

public class SetRightObstaclesSystem : IInitializeSystem
{
    private readonly IGroup<GameEntity> _obstacles;
    private readonly float _minX;
    private readonly float _maxX;
    private const float _rightLineSize = 2;

    public SetRightObstaclesSystem(GameContext game)
    {
        _obstacles = game.GetGroup(GameMatcher.AllOf(GameMatcher.Obstacle));
        _minX = Random.Range(-2f, 0f);
        _maxX = _minX + _rightLineSize;
    }

    public void Initialize()
    {
        foreach (var obstacle in _obstacles.GetEntities())
            if (ContainsInRightLine(obstacle.position.value))
                obstacle.isRightObstacle = true;
    }

    private bool ContainsInRightLine(Vector3 position) => position.x > _minX && position.x < _maxX;
}