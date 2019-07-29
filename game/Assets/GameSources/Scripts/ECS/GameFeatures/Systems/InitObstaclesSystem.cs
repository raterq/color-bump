using Entitas;
using UnityEngine;

public class InitObstaclesSystem : IInitializeSystem
{
    private readonly GameContext _game;
    private readonly PositionService _service;

    public InitObstaclesSystem(GameContext game, PositionService service)
    {
        _game = game;
        _service = service;
    }

    public void Initialize()
    {
        var positions = _service.GetObstaclesPositions(5, Random.Range(5,10));
        foreach (var positionData in positions)
        {
            var obstacle = _game.CreateEntity();
            obstacle.isObstacle = true;

            obstacle.AddPosition(positionData.Position);
            obstacle.AddScale(positionData.Size.x, positionData.Size.y, positionData.Size.z);
        }
    }
}