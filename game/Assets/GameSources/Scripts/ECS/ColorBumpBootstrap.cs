using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class ColorBumpBootstrap : MonoBehaviour
{
    private Systems _gameSystems;


    private void Awake()
    {
        var contexts = Contexts.sharedInstance;
        _gameSystems = new GameSystems(contexts.game, new GameObjectFactory());
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
    public GameSystems(GameContext game, GameObjectFactory factory)
    {
        Add(new ScreenSizeFeature(game));
        Add(new InputTapFeature(game));
        Add(new OutOfScreenFeature(game));

        Add(new GameplayFeature(game, factory));

        Add(new TransformFeature(game));
        Add(new DestroyFeature(game));
    }
}

public class GameplayFeature : Feature
{
    public GameplayFeature(GameContext game, GameObjectFactory factory)
    {
        
    }
}