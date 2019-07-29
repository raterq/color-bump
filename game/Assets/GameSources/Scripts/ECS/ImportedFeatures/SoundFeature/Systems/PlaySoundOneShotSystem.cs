#if EASY_JENNY
using Entitas;

public class PlaySoundOneShotSystem : IExecuteSystem
{
	private readonly IGroup<GameEntity> _group;

	public PlaySoundOneShotSystem(GameContext game)
	{
		_group = game.GetGroup(GameMatcher.AllOf(GameMatcher.PlaySoundOneShot, GameMatcher.PlaySoundBehaviour));
	}

	public void Execute()
	{
		foreach (var entity in _group.GetEntities())
		{
			entity.playSoundBehaviour.value.PlaySoundOneShot(entity.playSoundOneShot.path);
			entity.RemovePlaySoundOneShot();
		}
	}
}

#endif