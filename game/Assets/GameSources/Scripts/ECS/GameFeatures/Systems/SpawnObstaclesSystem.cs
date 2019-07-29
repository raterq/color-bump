using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class SpawnObstaclesSystem : IInitializeSystem
{
    private readonly GameObjectFactory _factory;
    private readonly IGroup<GameEntity> _obstacles;

    private readonly List<string> _obstaclesNames = new List<string> {"Cube", "Cylinder"};

    public SpawnObstaclesSystem(GameContext game, GameObjectFactory factory)
    {
        _factory = factory;
        _obstacles = game.GetGroup(GameMatcher.AllOf(GameMatcher.Obstacle).NoneOf(GameMatcher.TransformReplacer, 
            GameMatcher.ObstacleBehaviour));
    }

    public void Initialize()
    {
        foreach (var obstacle in _obstacles.GetEntities())
        {
            var name = _obstaclesNames[Random.Range(0, _obstaclesNames.Count)];
            var gameObject = _factory.Instantiate(name);

            obstacle.AddTransformReplacer(gameObject.AddComponent<TransformReplacer>());
            obstacle.AddObstacleBehaviour(gameObject.AddComponent<ObstacleBehaviour>());
        }
    }
}