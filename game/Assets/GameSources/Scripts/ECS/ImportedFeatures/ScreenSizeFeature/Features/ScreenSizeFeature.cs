#if EASY_JENNY
using BiniMonsters.Extensions;

public class ScreenSizeFeature : Feature
{
    public ScreenSizeFeature(GameContext game)
    {
        this.AddInitializeSystems
        (
            new CreateScreenSizeSystem(game),
            new CalculateScreenSizeSystem(game)
        );
    }
}

#endif