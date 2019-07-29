using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class SpawnCharacterSystem : IInitializeSystem
{
    private readonly GameObjectFactory _factory;
    private readonly IGroup<GameEntity> _characters;

    private const string _characterName = "Character";

    public SpawnCharacterSystem(GameContext game, GameObjectFactory factory)
    {
        _factory = factory;
        _characters = game.GetGroup(GameMatcher.AllOf(GameMatcher.Character).NoneOf(GameMatcher.TransformReplacer));
    }

    public void Initialize()
    {
        foreach (var character in _characters.GetEntities())
        {
            var gameObject = _factory.Instantiate(_characterName);

            character.AddTransformReplacer(gameObject.AddComponent<TransformReplacer>());
        }
    }
}