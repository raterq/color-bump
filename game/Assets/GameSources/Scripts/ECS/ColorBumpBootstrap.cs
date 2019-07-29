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
        Add(new ScreenSizeFeature(game));
        Add(new InputTapFeature(game));
        Add(new OutOfScreenFeature(game));

        Add(new GameplayFeature(game, factory, positionService));

        Add(new TransformFeature(game));
        Add(new DestroyFeature(game));
    }
}

public class GameplayFeature : Feature
{
    public GameplayFeature(GameContext game, GameObjectFactory factory, PositionService positionService)
    {
        Add(new InitObstaclesSystem(game, positionService));
        Add(new SpawnObstaclesSystem(game, factory));

        Add(new SetRightObstaclesSystem(game));
        Add(new SetRightObstacleColorSystem(game));
        Add(new SetNotRightObstacleColorSystem(game));
    }
}