using UnityEngine;

public class PlaySoundBehaviour : MonoBehaviour, IPlaySound
{
	private SoundController _controller;

	private void Awake()
	{
//		_controller = SoundController.instance;
	}

	public void PlaySoundOneShot(string path)
	{
		var clip = Resources.Load(path) as AudioClip;
		_controller.PlaySoundOneShot(clip);
	}
}
