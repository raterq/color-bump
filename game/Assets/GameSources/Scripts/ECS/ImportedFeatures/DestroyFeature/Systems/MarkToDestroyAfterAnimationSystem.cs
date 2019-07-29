#if EASY_JENNY
using Entitas;

//public class MarkToDestroyAfterAnimationSystem : ICleanupSystem
//{
//	private readonly IGroup<GameEntity> _objects;
//
//	public MarkToDestroyAfterAnimationSystem(GameContext game)
//	{
//		_objects = game.GetGroup(GameMatcher.AllOf(GameMatcher.DestroyAfterAnimationFinished)
//			.NoneOf(GameMatcher.AnimationPlaying));
//	}
//
//	public void Cleanup()
//	{
//		foreach (var item in _objects.GetEntities())
//		{
//			item.isDestroyed = true;
//		}
//	}
//}


#endif