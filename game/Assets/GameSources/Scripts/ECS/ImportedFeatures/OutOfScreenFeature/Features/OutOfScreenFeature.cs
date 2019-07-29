#if EASY_JENNY
using BiniMonsters.Extensions;

public class OutOfScreenFeature : Feature
{
    public OutOfScreenFeature(GameContext game)
    {
        this.AddExecuteSystems
        (
            new AddOutOfScreenComponentSystem(game),
            new RemoveOutOfScreenComponentSystem(game)
        );
    }
}

#endif