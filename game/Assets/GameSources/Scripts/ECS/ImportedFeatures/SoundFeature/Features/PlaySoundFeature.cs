#if EASY_JENNY
using BiniMonsters.Extensions;

public class PlaySoundFeature : Feature
{
    public PlaySoundFeature(GameContext game)
    {
        this.AddExecuteSystems
        (
            new PlaySoundOneShotSystem(game)
        );
    }
}

#endif