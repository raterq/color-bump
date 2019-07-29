#if EASY_JENNY
using BiniMonsters.Extensions;

public class InputTapFeature : Feature
{
    public InputTapFeature(GameContext game)
    {
        this.AddExecuteSystems
        (
            new AddTappedComponentSystem(game),
            new RemoveTappedComponentSystem(game)
        );
    }
}

#endif