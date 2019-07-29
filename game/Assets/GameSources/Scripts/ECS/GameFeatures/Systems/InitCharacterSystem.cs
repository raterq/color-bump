using Entitas;
using UnityEngine;

public class InitCharacterSystem : IInitializeSystem
{
    private readonly GameContext _game;
    private readonly Vector3 _characterPosition = new Vector3(0,0.6f,-13);

    public InitCharacterSystem(GameContext game)
    {
        _game = game;
    }

    public void Initialize()
    {
        var character = _game.CreateEntity();
        character.isCharacter = true;
        character.AddPosition(_characterPosition);
    }
}