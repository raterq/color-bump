#if EASY_JENNY
using BiniMonsters.Extensions;

public class TransformFeature : Feature
{
    public TransformFeature(GameContext game)
    {
        this.AddExecuteSystems
        (
            new SinusoidalMoveSystem(game),
            new RotateObjectsSystem(game),
            new MoveToPositionTowardsSystem(game),
            new MoveToPositionLerpSystem(game),
            new DirectionMoveSystem(game),
            new SynchronizePositionSystem(game),
            new SynchronizeScaleSystem(game)
        );
    }
}

#endif