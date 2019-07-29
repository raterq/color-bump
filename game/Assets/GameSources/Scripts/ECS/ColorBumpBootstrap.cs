using Entitas;
using UnityEngine;

public class ColorBumpBootstrap : MonoBehaviour
{
    private Systems _gameSystems;


    private void Awake()
    {
        var contexts = Contexts.sharedInstance;
        _gameSystems = new GameSystems(contexts.game, new GameObjectFactory(), new PositionService());
    }

    private void Start()
    {
        _gameSystems.Initialize();
    }

    private void Update()
    {
        _gameSystems.Execute();
        _gameSystems.Cleanup();
    }

    private void OnDestroy()
    {
        _gameSystems.TearDown();
    }
}

public sealed class GameSystems : Systems
{
    public GameSystems(GameContext game, GameObjectFactory factory, PositionService positionService)
    {
        Add(new GameplayFeature(game, factory, positionService));

        Add(new TransformFeature(game));
    }
}

public class GameplayFeature : Feature
{
    public GameplayFeature(GameContext game, GameObjectFactory factory, PositionService positionService)
    {
        Add(new InitObstaclesSystem(game, positionService));
        Add(new InitCharacterSystem(game));

        Add(new SpawnObstaclesSystem(game, factory));
        Add(new SpawnCharacterSystem(game, factory));

        Add(new SetObstaclePositionSystem(game));
        Add(new SetRightObstaclesSystem(game));
        Add(new SetRightObstacleColorSystem(game));
        Add(new SetNotRightObstacleColorSystem(game));
    }
}