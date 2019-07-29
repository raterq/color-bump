#if EASY_JENNY
using BiniMonsters.Extensions;

public class DestroyFeature : Feature
{
    public DestroyFeature(GameContext game)
    {
        this.AddCleanupSystems
        (
            new MarkToDestroyAfterOutOfScreenSystem(game),
//            new MarkToDestroyAfterAnimationSystem(game),
            new TriggerDestroyerSystem(game),
            new DestroySystem(game)
        );
    }
}

#endif